using teste.ContentContext;
using teste.NotificationContext;

namespace teste.SubscriptionContext{
    public class Student: Base{
        public Student()
        {
            Subscriptions = new List<Subscription>();
            
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription){
            if(IsPremium){
                AddNotification(new Notification("Premium","O aluno ja possui uma assinatura premium"));
                return;
            }

            Subscriptions.Add(subscription);
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}