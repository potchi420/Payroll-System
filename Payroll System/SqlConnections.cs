
namespace Payroll_System
{
    internal class SqlConnections
    {
        private string con;

        public SqlConnections(string con)
        {
            this.con = con;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}