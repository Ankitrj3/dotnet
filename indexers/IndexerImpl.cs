namespace Ankit
{
    class IndexerImpl
    {
        private string[] CoreSubject = new string[3];

        public string this[int index]
        {
            get
            {
                return CoreSubject[index];
            }
            set
            {
                CoreSubject[index] = value;
            }
        }
    }
}