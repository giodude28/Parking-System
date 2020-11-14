#include<Servo.h>
Servo myservo;

int echo1=4;
int trigger1=5;
 
int echo2=6;
int trigger2=7;
 
int echo3=8;
int trigger3=9; 

int echo4=10;
int trigger4=11;
 
int echo5=12;
int trigger5=13; 


int echo6=14;
int trigger6=15;
 
int echo7=16;
int trigger7=17; 

int echo8= 18;
int trigger8=19; 

int led1 = 21;
int led1R = 22;

int led2 = 23;
int led2R = 24;

int led3 = 25;
int led3R = 26;

int led4 = 27;
int led4R = 28;

int led5 = 29;
int led5R = 30;

int led6 = 31;
int led6R = 32;

int led7 = 33;
int led7R = 34;

int led8 = 35;
int led8R = 36;



float distance1;
float distance2; 
float distance3; 
float distance4; 
float distance5;
float distance6; 
float distance7; 
float distance8;

String sensor1;
String sensor2;
String sensor3;
String sensor4;
String sensor5;
String sensor6;
String sensor7;
String sensor8;


String cdata="";
int val;
String s1;
String s2;
String s3;
String s4;
String s5;

     
void setup() {
Serial.begin(9600); 
myservo.attach(20);

pinMode(trigger1,OUTPUT);    
pinMode(echo1,INPUT); 

pinMode(trigger2,OUTPUT);    
pinMode(echo2,INPUT); 

pinMode(trigger3,OUTPUT);    
pinMode(echo3,INPUT); 

pinMode(trigger4,OUTPUT);    
pinMode(echo4,INPUT); 

pinMode(trigger5,OUTPUT);    
pinMode(echo5,INPUT); 

pinMode(trigger6,OUTPUT);    
pinMode(echo6,INPUT); 

pinMode(trigger7,OUTPUT);    
pinMode(echo7,INPUT); 

pinMode(trigger8,OUTPUT);    
pinMode(echo8,INPUT);

pinMode(led1,OUTPUT);
pinMode(led1R,OUTPUT);
pinMode(led2,OUTPUT);
pinMode(led2R,OUTPUT);
pinMode(led3,OUTPUT);
pinMode(led3R,OUTPUT);
pinMode(led4,OUTPUT);
pinMode(led4R,OUTPUT);
pinMode(led5,OUTPUT);
pinMode(led5R,OUTPUT);
pinMode(led6,OUTPUT);
pinMode(led6R,OUTPUT);
pinMode(led7,OUTPUT);
pinMode(led7R,OUTPUT);
pinMode(led8,OUTPUT);
pinMode(led8R,OUTPUT);

}

void loop() { 
    digitalWrite(trigger1,LOW);   
    delayMicroseconds(5); 
    digitalWrite(trigger1,HIGH); // Start Measurement     
    delayMicroseconds(10);     
    digitalWrite(trigger1,LOW);  
     pinMode(echo1, INPUT);
    distance1=pulseIn(echo1,HIGH); // Acquire and convert to mtrs
    distance1=(distance1/2)/ 29.1;  
    delay(150);
    
    digitalWrite(trigger2,LOW);   
    delayMicroseconds(5); 
    digitalWrite(trigger2,HIGH); // Start Measurement     
    delayMicroseconds(10);     
    digitalWrite(trigger2,LOW);  
    pinMode(echo2, INPUT);
    distance2=pulseIn(echo2,HIGH); // Acquire and convert to mtrs    
    distance2=(distance2/2)/ 29.1;   
    delay(150);
    
    digitalWrite(trigger3,LOW);   
    delayMicroseconds(5); 
    digitalWrite(trigger3,HIGH); // Start Measurement     
    delayMicroseconds(10);     
    digitalWrite(trigger3,LOW);  
    pinMode(echo3, INPUT);
    distance3=pulseIn(echo3,HIGH); // Acquire and convert to mtrs    
    distance3=(distance3/2)/ 29.1; 
delay(150);
    digitalWrite(trigger4,LOW);   
    delayMicroseconds(5); 
    digitalWrite(trigger4,HIGH); // Start Measurement     
    delayMicroseconds(10);     
    digitalWrite(trigger4,LOW); 
    pinMode(echo4, INPUT); 
    distance4=pulseIn(echo4,HIGH); // Acquire and convert to mtrs    
    distance4=(distance4/2)/ 29.1; 
    delay(150);
    digitalWrite(trigger5,LOW);   
    delayMicroseconds(5); 
    digitalWrite(trigger5,HIGH); // Start Measurement     
    delayMicroseconds(10);     
    digitalWrite(trigger5,LOW); 
    pinMode(echo5, INPUT); 
    distance5=pulseIn(echo5,HIGH); // Acquire and convert to mtrs    
    distance5=(distance5/2)/ 29.1;  
delay(150);
  digitalWrite(trigger6,LOW);   
    delayMicroseconds(5); 
    digitalWrite(trigger6,HIGH); // Start Measurement     
    delayMicroseconds(10);     
    digitalWrite(trigger6,LOW); 
    pinMode(echo6, INPUT); 
    distance6=pulseIn(echo6,HIGH); // Acquire and convert to mtrs    
    distance6=(distance6/2)/ 29.1; 
delay(150);
    digitalWrite(trigger7,LOW);   
    delayMicroseconds(5); 
    digitalWrite(trigger7,HIGH); // Start Measurement     
    delayMicroseconds(10);     
    digitalWrite(trigger7,LOW);  
    pinMode(echo7, INPUT);
    distance7=pulseIn(echo7,HIGH); // Acquire and convert to mtrs    
    distance7=(distance7/2)/ 29.1;  
delay(150);
    digitalWrite(trigger8,LOW);   
    delayMicroseconds(5); 
    digitalWrite(trigger8,HIGH); // Start Measurement     
    delayMicroseconds(10);     
    digitalWrite(trigger8,LOW);  
    pinMode(echo8, INPUT);
    distance8=pulseIn(echo8,HIGH); // Acquire and convert to mtrs    
    distance8=(distance8/2)/ 29.1; 
    delay(150);
  
  serialEvent();

test1();
test2();
test3();
test4();
test5();
test6();
test7();
test8();

  cdata = cdata + sensor1 + "," + sensor2 + "," + sensor3 + "," + sensor4 + "," + sensor5 + "," + sensor6 + "," + sensor7 + "," + sensor8 + ",";
Serial.println(cdata);
cdata="";
}

void test1()
{
 // Serial.println(distance1);   
  if (distance1 >= 12.5)   
   {
    sensor1 = "off";
     digitalWrite(led1, HIGH);
  digitalWrite(led1R, LOW);

   }
else
{  
 sensor1 = "on";
   digitalWrite(led1, LOW);
     digitalWrite(led1R, HIGH);
}
}

void test2()
{
 //Serial.println(distance2);  
    if (distance2>= 10)   
   {
    sensor2 = "off";
         digitalWrite(led2, HIGH);
  digitalWrite(led2R, LOW);
   }
else
{  
 sensor2 = "on";
  digitalWrite(led2, LOW);
     digitalWrite(led2R, HIGH);
}
}

void test3()
{
// Serial.println(distance3);  
     if (distance3>=10)   
   {
    sensor3 ="off";
             digitalWrite(led3, HIGH);
  digitalWrite(led3R, LOW);
   }
else
{  
 sensor3 = "on";
 digitalWrite(led3, LOW);
     digitalWrite(led3R, HIGH);
}
}

void test4()
{
//Serial.println(distance4);  
   if (distance4>=12.5)   
   {
    sensor4 ="off";
                 digitalWrite(led4, HIGH);
  digitalWrite(led4R, LOW);
   }
else
{  
 sensor4 ="on";
  digitalWrite(led4, LOW);
     digitalWrite(led4R, HIGH);
}
}

void test5()
{
//Serial.println(distance5);  
   if (distance5>=12.5)   
   {
    sensor5 = "off";
  digitalWrite(led5, HIGH);
  digitalWrite(led5R, LOW);
   }
else
{  
 sensor5 ="on";
   digitalWrite(led5, LOW);
     digitalWrite(led5R, HIGH);
}
}

void test6()
{
 //Serial.println(distance6);  
   if (distance6>=12.5)   
   {
    sensor6 ="off";
    digitalWrite(led6, HIGH);
  digitalWrite(led6R, LOW);
   }
else
{  
 sensor6 ="on";
 digitalWrite(led6, LOW);
     digitalWrite(led6R, HIGH);
}
}

void test7()
{
//Serial.println(distance7);  
   if (distance7>=12.5)   
   {
    sensor7 ="off";
      digitalWrite(led7, HIGH);
  digitalWrite(led7R, LOW);
   }
else
{  
 sensor7 ="on";
  digitalWrite(led7, LOW);
     digitalWrite(led7R, HIGH);
}
}

void test8()
{
// Serial.println(distance8);  
   if (distance8>=12.5)   
   {
    sensor8 = "off";
       digitalWrite(led8, HIGH);
  digitalWrite(led8R, LOW);
   }
else
{  
 sensor8 ="on";
  digitalWrite(led8, LOW);
     digitalWrite(led8R, HIGH);
}
}

void serialEvent(){ 
    val = Serial.parseInt();
    if(val != 0){
        myservo.write(val);
    }

  }
