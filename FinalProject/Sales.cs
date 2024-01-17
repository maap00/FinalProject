using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Sales
    {
        private int _inSales;
        private string _comments;
        private int _idUsuario;

        public Sales() { 
            this._inSales = 0;
            this._comments = string.Empty;
            this._idUsuario = 0;
        }

        public Sales (int inSales, string comments, int idUsuario) {
            this._inSales = inSales;
            this._comments = comments;
            this._idUsuario = idUsuario;
        }

        public int InSales { get { return this._inSales; } set { this._inSales = value; } }
        public string Comments { get { return this._comments; } set { this._comments = value; } }
        public int IdUsuario { get {  return this._idUsuario; } set { this._idUsuario = value; } } 
    }
}
