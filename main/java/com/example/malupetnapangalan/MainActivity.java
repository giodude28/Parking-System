package com.example.malupetnapangalan;

import androidx.appcompat.app.AppCompatActivity;

import android.app.ProgressDialog;
import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.Handler;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.io.ByteArrayOutputStream;
import java.sql.Blob;

import java.io.PrintWriter;
import java.io.StringWriter;
import java.io.Writer;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Timer;
import java.util.TimerTask;

public class MainActivity extends AppCompatActivity {
    private ArrayList<ClassListItems> ItemArrayList;
    private MyAppAdapter myAppAdapter;
    private ListView listView;
    private boolean success = false;
    TextView txtnum;
    Button mapp;
 //s   Button btnview;
    ClassConUrl cUrl = new ClassConUrl();
    Timer timer;
    //int count = 0;
    Handler handler = new Handler();
    Runnable runnable;
    int delay = 5*1000;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        txtnum = findViewById(R.id.num);
       // btnview = findViewById(R.id.btnclick);
        listView = findViewById(R.id.listView);
        mapp = findViewById(R.id.map);
        ItemArrayList = new ArrayList<ClassListItems>();
    //    timer = new Timer();
   //   timer.schedule(new TimerTask(){
     //      @Override
         // public void run(){
    //            Login login = new Login();
    //            login.execute();

     //       }
   //   },5000);
        mapp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(MainActivity.this, Vieww.class);
                startActivity(intent);
            }
        });
    }

    @Override
    protected void onResume() {
        //start handler as activity become visible

        handler.postDelayed( runnable = new Runnable() {
         public void run() {
           Login login = new Login();
           login.execute();
                //ListView.Items.Clear();
               ItemArrayList.clear();
              SyncData orderData = new SyncData();
                orderData.execute("");

                handler.postDelayed(runnable, delay);
            }
        }, delay);

        super.onResume();
    }

    @Override
   protected void onPause() {
       handler.removeCallbacks(runnable); //stop handler when activity not visible
        super.onPause();
   }
    // Async Task has three overrided methods,
    class SyncData extends AsyncTask<String, String, String> {
        String msg = "Internet/DB_Credentials/Windows_FireWall_TurnOn Error, See Android Monitor in the bottom For details!";
       // ProgressDialog progress;

        @Override
        protected void onPreExecute() //Starts the progress dailog
        {

         //   progress = ProgressDialog.show(MainActivity.this, "",
              //      "", true);
        }

        @Override
        protected String doInBackground(String... strings)  // Connect to the database, write query and add items to array list
        {
            try {
                String connectionUrl = cUrl.conUrl();
                Connection con = DriverManager.getConnection(connectionUrl);
                if (con == null) {
                    success = false;
                } else {
                    byte b[];
                    Blob blob;
                    // Change below query according to your own database.
                    String query = "SELECT * FROM mapping WHERE status = '"+"Vacant"+"'";
                    Statement stmt = con.createStatement();
                    ResultSet rs = stmt.executeQuery(query);
                    if (rs != null) // if resultset not null, I add items to itemArraylist using class created
                    {
                        while (rs.next()) {
                            try {
                                blob = rs.getBlob("img");
                                b=blob.getBytes(1, (int) blob.length());
                                Bitmap bitmap = BitmapFactory.decodeByteArray(b, 0,b.length);
                                ItemArrayList.add(new ClassListItems(rs.getString("name"),bitmap));

                            } catch (Exception ex) {
                                ex.printStackTrace();
                            }
                        }
                        msg = "Refresh";
                        success = true;
                    } else {
                        msg = "No Data found!";
                        success = false;
                    }
                }
            } catch (Exception e) {
                e.printStackTrace();
                Writer writer = new StringWriter();
                e.printStackTrace(new PrintWriter(writer));
                msg = writer.toString();
                success = false;
            }

            return msg;
        }

        @Override
        protected void onPostExecute(String msg) // disimissing progress dialoge, showing error and setting up my ListView
        {
          //  progress.dismiss();
            Toast.makeText(MainActivity.this, msg + "", Toast.LENGTH_LONG).show();
            if (success == false) {
            } else {
                try {
                    myAppAdapter = new MyAppAdapter(ItemArrayList, MainActivity.this);
                    listView.setChoiceMode(ListView.CHOICE_MODE_MULTIPLE);
                    listView.setAdapter(myAppAdapter);
                    //   listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
                    //        @Override
                    //       public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                    //           Toast.makeText(Booklist.this,"You have clocked on:"+itemArrayList.get(position).toString(), Toast.LENGTH_LONG).show();
                    //        }
                    //    });

                } catch (Exception ex) {

                }

            }

        }
    }

    public class MyAppAdapter extends BaseAdapter         //has a class viewholder which holds
    {
        public class ViewHolder {
            TextView name;
            ImageView picture;
        }

        public List<ClassListItems> parkingList;

        public Context context;
        ArrayList<ClassListItems> arraylist;

        private MyAppAdapter(List<ClassListItems> apps, Context context) {
            this.parkingList = apps;
            this.context = context;
            arraylist = new ArrayList<ClassListItems>();
            arraylist.addAll(parkingList);
        }

        @Override
        public int getCount() {
            return parkingList.size();
        }

        @Override
        public Object getItem(int position) {
            return parkingList.get(position);
        }

        @Override
        public long getItemId(int position) {
            return position;
        }

        @Override
        public View getView(final int position, View convertView, ViewGroup parent) // inflating the layout and initializing widgets
        {

            View rowView = convertView;
            ViewHolder viewHolder = null;
            if (rowView == null) {
                LayoutInflater inflater = getLayoutInflater();
                rowView = inflater.inflate(R.layout.list_content, parent, false);
                viewHolder = new ViewHolder();
                viewHolder.name = rowView.findViewById(R.id.textName);
               // viewHolder.picture = rowView.findViewById(R.id.pic);
                rowView.setTag(viewHolder);
                //viewHolder.imahe = rowView.findViewById(R.id.image);
               // rowView.setTag(viewHolder);
            } else {
                viewHolder = (ViewHolder) convertView.getTag();
            }
            // here setting up names and images
            viewHolder.name.setText(parkingList.get(position).getName() + "");
          // viewHolder.picture.setImageBitmap(parkingList.get(position).getImage() + "");

          // rowView.setOnClickListener(new View.OnClickListener() {
           //    @Override
            //   public void onClick(View v) {
                  //  Toast.makeText(ProductList.this, "You have clocked on:" + parkingList.get(position).getProductBrand() + "  " + parkingList.get(position).getProductName(), Toast.LENGTH_LONG).show();
              //     Intent intent = new Intent(MainActivity.this, View.class);
                 //   intent.putExtra("pid", parkingList.get(position).getProductID());
                  //  intent.putExtra("brand", parkingList.get(position).getProductBrand());
                 //   intent.putExtra("name", parkingList.get(position).getProductName());
                 //   intent.putExtra("name", parkingList.get(position).getName());
                   //  Bitmap b = parkingList.get(position).getImage();
                //   ByteArrayOutputStream bStream = new ByteArrayOutputStream();
                 //   b.compress(Bitmap.CompressFormat.PNG, 20, bStream);
               //     byte[] byteArray = bStream.toByteArray();
               //     intent.putExtra("image",byteArray);
            //       startActivity(intent);
          //     }
          // });
          return rowView;
        }

        public void filter(String charText) {
            charText = charText.toLowerCase(Locale.getDefault());
            parkingList.clear();

            if (charText.length() == 0) {
                parkingList.addAll(arraylist);
            } else {
                for (ClassListItems model : arraylist) {
                    if (model.getName().toLowerCase(Locale.getDefault()).contains(charText)) {
                        parkingList.add(model);
                    }
                }
            }
            notifyDataSetChanged();
        }
    }
    public class Login extends AsyncTask<String, String, String> {
        Integer insidenumber;
        Integer totalnumber;
        String msg;
        boolean loadDbSuccess = false;

        @Override
        protected String doInBackground(String... strings) {
            try {
                String connectionUrl = cUrl.conUrl();
                Connection con = DriverManager.getConnection(connectionUrl);
                if (con == null) {
                    loadDbSuccess = false;
                } else {
                    String sql = "SELECT COUNT(*)AS tite FROM intbl";

                    Statement stmt = con.createStatement();
                    ResultSet rs = stmt.executeQuery(sql);

                    while (rs.next()) {
                        insidenumber = rs.getInt("tite");
                    }
                    String lqs = "SELECT * FROM slottbl";

                    ResultSet sr = stmt.executeQuery(lqs);

                    while (sr.next()) {
                        totalnumber = sr.getInt("NumberofSlot");
                    }
                    loadDbSuccess = true;
                }
            } catch (SQLException e) {
                msg = "Exception: " + e.toString();
                loadDbSuccess = false;
            } catch (ClassNotFoundException e) {
                e.printStackTrace();
            }

            return msg;

        }
        @Override
        protected void onPostExecute(String s) {
            super.onPostExecute(s);
            if(loadDbSuccess){
                //Toast.makeText(getBaseContext(), "Preparing..", Toast.LENGTH_LONG).show();
                Integer total = totalnumber - insidenumber;
                txtnum.setText(String.valueOf(total));
            } else {
                Toast.makeText(getBaseContext(), msg, Toast.LENGTH_LONG).show();
            }
        }
    }
}
