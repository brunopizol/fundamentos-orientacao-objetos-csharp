using teste.NotificationContext;

namespace teste.ContentContext
{
    public abstract class Base : Notifiable{

        public Base(){
            Id = Guid.NewGuid();
        }
        
        public Guid Id { get; set; }
        
    }

    
}