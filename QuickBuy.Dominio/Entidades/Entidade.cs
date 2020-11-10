using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }

        private List<string> mensagemValicao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValicao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValicao.Add(mensagem);
        }

        /// <summary>
        /// abstract força que as classes filhas implementem o método
        /// </summary>
        public abstract void Validate();

        protected bool EhValido
        {
            get { return !mensagemValicao.Any(); }
        }
    }
}
