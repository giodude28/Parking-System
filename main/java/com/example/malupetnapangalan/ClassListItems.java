package com.example.malupetnapangalan;

import android.graphics.Bitmap;

public class ClassListItems {
    public String name;
    public Bitmap img;
    public ClassListItems(String name,Bitmap img)
    {
        this.name = name;
        this.img = img;
    }
    public String getName(){
        return name;
    }
    public Bitmap getImage(){
        return img;
    }
}
