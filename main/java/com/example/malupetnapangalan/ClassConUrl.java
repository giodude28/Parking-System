package com.example.malupetnapangalan;

public class ClassConUrl {
    public String conUrl() throws ClassNotFoundException{
        Class.forName("com.mysql.jdbc.Driver");
        String connectionUrl = "jdbc:mysql://192.168.43.144/parking?" + "user=test&password=test";

        return connectionUrl;
    }
}
