#ifndef SENDDATA_H
#define SENDDATA_H



class Send {
  
  private:
    byte int_LED;
    
  public:
    
    Send(byte int_LED);
    
    void init();
    
    
    void send_data();
    
    
};
#endif