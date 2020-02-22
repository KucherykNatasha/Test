
namespace TestTask.Models.Observer
{
    public class Observer : IObserver
    {
        ISubject subject;
        string jOriginal;
        string jUpdate;
        Comparator compar;
        
        public Observer(ISubject subject, string jOrig, string jUpd, Comparator comp)
        {
            this.subject = subject;
            jOriginal = jOrig;
            jUpdate = jUpd;
            compar = comp;
            
            subject.AddObserver(this);
        }
        public void Update()
        {
           
           compar.JsonCompare(jOriginal, jUpdate);
           

        }
        
    }
}
