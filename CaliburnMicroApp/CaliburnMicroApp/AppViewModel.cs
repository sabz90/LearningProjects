using Caliburn.Micro;

namespace CaliburnMicroApp
{
    public class AppViewModel : PropertyChangedBase
    {
        private int _count = 50;

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                NotifyOfPropertyChange(() => Count);
            }
        }
        public bool CanIncrementCount
        {
            get { return Count < 100; }
        }
        public void IncrementCount()
        {
            Count++;
            NotifyOfPropertyChange(() => CanIncrementCount);
        }
    }
}