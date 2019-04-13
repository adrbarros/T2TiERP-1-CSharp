using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using PatrimonioClient.ServicoPatrimonioReference;
using PatrimonioClient.Command;
using SearchWindow;
using PatrimonioClient.Model;

namespace PatrimonioClient.ViewModel.Patrimonio
{
	/// 
	/// The MIT License
	///
	/// Copyright: Copyright (C) 2010 T2Ti.COM
	///
	/// Permission is hereby granted, free of charge, to any person
	/// obtaining a copy of this software and associated documentation
	/// files (the "Software"), to deal in the Software without
	/// restriction, including without limitation the rights to use,
	/// copy, modify, merge, publish, distribute, sublicense, and/or sell
	/// copies of the Software, and to permit persons to whom the
	/// Software is furnished to do so, subject to the following
	/// conditions:
	///
	/// The above copyright notice and this permission notice shall be
	/// included in all copies or substantial portions of the Software.
	///
	/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
	/// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
	/// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
	/// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
	/// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
	/// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
	/// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
	/// OTHER DEALINGS IN THE SOFTWARE.
	///
	///        The author may be contacted at:
	///            t2ti.com@gmail.com
	///
	/// Autor: Miguel Kojiio (t2ti.com@gmail.com)
	/// Version: 1.0
    public class PatrimApoliceSeguroViewModel : ERPViewModelBase
    {
        public ObservableCollection<PatrimApoliceSeguroDTO> ListaPatrimApoliceSeguro { get; set; }
        private PatrimApoliceSeguroDTO _PatrimApoliceSeguroSelected;
        private int primeiroResultado;
        protected ICommand seguinteCommand;
        protected ICommand anteriorCommand;
        private bool _isEditar { get; set; }


        public PatrimApoliceSeguroViewModel()
        {
            try
            {
                ListaPatrimApoliceSeguro = new ObservableCollection<PatrimApoliceSeguroDTO>();
                primeiroResultado = 0;
                this.atualizarListaPatrimApoliceSeguro(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PatrimApoliceSeguroDTO PatrimApoliceSeguroSelected
        {
            get { return _PatrimApoliceSeguroSelected; }
            set
            {
                _PatrimApoliceSeguroSelected = value;
                notifyPropertyChanged("PatrimApoliceSeguroSelected");
            }
        }

        public ICommand paginaSeguinteCommand
        {
            get
            {
                if (seguinteCommand == null)
                {
                    seguinteCommand = new RelayCommand
                    (
                        param =>
                        {
                            this.atualizarListaPatrimApoliceSeguro(1);
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return seguinteCommand;
            }
        }

        public ICommand paginaAnteriorCommand
        {
            get
            {
                if (anteriorCommand == null)
                {
                    anteriorCommand = new RelayCommand
                    (
                        param =>
                        {
                            this.atualizarListaPatrimApoliceSeguro(-1);
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return anteriorCommand;
            }
        }

        public void salvarAtualizarPatrimApoliceSeguro()
        {
            try
            {
                using (ServicoPatrimonioClient serv = new ServicoPatrimonioClient())
                {
                    serv.salvarAtualizarPatrimApoliceSeguro(PatrimApoliceSeguroSelected);
                    PatrimApoliceSeguroSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void atualizarListaPatrimApoliceSeguro(int pagina)
        {
            try
            {
                using (ServicoPatrimonioClient serv = new ServicoPatrimonioClient())
                {
                    if (pagina == 0)
                        primeiroResultado = 0;
                    else if (pagina > 0)
                        primeiroResultado += QUANTIDADE_PAGINA;
                    else if (pagina < 0)
                        primeiroResultado -= QUANTIDADE_PAGINA;

                    List<PatrimApoliceSeguroDTO> listaServ = serv.selectPatrimApoliceSeguroPagina(primeiroResultado, QUANTIDADE_PAGINA, new PatrimApoliceSeguroDTO());

                    ListaPatrimApoliceSeguro.Clear();

                    foreach (PatrimApoliceSeguroDTO objAdd in listaServ)
                    {
                        ListaPatrimApoliceSeguro.Add(objAdd);
                    }
                    PatrimApoliceSeguroSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void excluirPatrimApoliceSeguro()
        {
            try
            {
                using (ServicoPatrimonioClient serv = new ServicoPatrimonioClient())
                {
                    serv.deletePatrimApoliceSeguro(PatrimApoliceSeguroSelected);
                    PatrimApoliceSeguroSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsEditar
        {
            get { return _isEditar; }
            set
            {
                _isEditar = value;
                notifyPropertyChanged("IsEditar");
                notifyPropertyChanged("IsListar");
            }
        }

        public bool IsListar
        {
            get { return !_isEditar; }
            set
            {
                _isEditar = !value;
                notifyPropertyChanged("IsEditar");
                notifyPropertyChanged("IsListar");
            }
        }

        public void pesquisarSeguradora()
        {
            try
            {
                SearchWindowApp searchWindow = new SearchWindowApp(typeof(SeguradoraDTO),
                    typeof(ServicoPatrimonio));

                if (searchWindow.ShowDialog() == true)
                {
                    PatrimApoliceSeguroSelected.Seguradora = ((SeguradoraDTO)searchWindow.itemSelecionado);
                    notifyPropertyChanged("PatrimApoliceSeguroSelected");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void pesquisarPatrimBem()
        {
            try
            {
                SearchWindowApp searchWindow = new SearchWindowApp(typeof(PatrimBemDTO),
                    typeof(ServicoPatrimonio));

                if (searchWindow.ShowDialog() == true)
                {
                    PatrimApoliceSeguroSelected.PatrimBem = ((PatrimBemDTO)searchWindow.itemSelecionado);
                    notifyPropertyChanged("PatrimApoliceSeguroSelected");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
