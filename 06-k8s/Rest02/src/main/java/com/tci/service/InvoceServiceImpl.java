package com.tci.service;


//import java.io.FileInputStream;
//import java.io.IOException;

public class InvoceServiceImpl implements InvoceService {

    //TODO: 4 SB - Null
    @Override
    public Boolean booleanMethod() {
        return null;
    }

    //TODO: 5 SB - Null
    @Override
    public double circumference(double diameter) {

        return diameter * 3.141;
    }

    //TODO: No working exception

    @Override
    public void openFile() {
        /*try {
            FileInputStream fis = new FileInputStream("/tmp/bugger");
            fis.close();
        } catch (IOException ioe) {
            // not good
        }*/
    }


    //TODO: 3 Field no usada
    /*private String id;

    public InvoceServiceImpl(String id){
        id = id;
        this.id = id;
    }*/
}
