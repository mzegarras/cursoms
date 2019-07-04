package com.tci.config;

import com.tci.service.CustomerService;
import com.tci.service.CustomerServiceimpl;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class ServiceConfig {

    @Bean
    public CustomerService customerService(){
        CustomerService customerService = new CustomerServiceimpl();
        return customerService;
    }
}
