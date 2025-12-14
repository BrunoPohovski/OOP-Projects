using Priprema_za_M1.Extensions;

namespace Priprema_za_M1.Models
{
    public class Subject : ISignable
    {
        public Subject(int ects, string code, string title)
        {
            _ects = ects;
            Code = code;
            Title = title;
        }

        public string Code { get; set; }
        public string Title { get; set; }
        private int _ects;
        
        
        public bool Confirmed { get; private set; }
        public int Ects
        {
            get => _ects;
            set
            {
                if (value < 0) throw new System.Exception("Ects cannot be negative");
                {
                    _ects = value;
                }
            }
        }   
        
        public void Sign()
        => Confirmed = true;
        

        public override string ToString()
        {
            return $"Code: {Code}, Title: {Title}, Ects: {Ects.Format("ects")}, Confirmed: {(Confirmed ? "Yes" : "No")}";
        }
    }
}