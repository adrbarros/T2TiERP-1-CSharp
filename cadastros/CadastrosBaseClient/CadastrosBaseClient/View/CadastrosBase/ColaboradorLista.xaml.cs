using System;
using System.Windows;
using System.Windows.Controls;
using CadastrosBaseClient.ViewModel;
using ExportarParaArquivo.Control;
using CadastrosBaseClient.ViewModel.CadastrosBase;

namespace CadastrosBaseClient.View.CadastrosBase
{
    /// <summary>
    /// Interaction logic for Colaborador.xaml
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
	/// Autor: Albert Eije (t2ti.com@gmail.com)
	/// Version: 1.0
    /// </summary>
    public partial class ColaboradorLista : UserControl
    {
        public ColaboradorLista()
        {
            InitializeComponent();
        }

        private void ButtonExport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((ERPViewModelBase)DataContext).exportarDataGrid((ExportarParaArquivo.Formato)(
            (ButtonExport)sender).ExportFileFormat,
            (DataGrid)((ButtonExport)sender).ExportDataGridSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }

        private void btRelatorio_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.SelectedItem = dataGrid.Items[0];
            int offset = ((ColaboradorViewModel)DataContext).ColaboradorSelected.Id - 1;

            string ConsultaSQL = 
                                "select c.id, p.nome as colaborador, sc.nome as situacao, nf.nome as nivelformacao, nf.grau_instrucao_caged, ca.nome as cargo, s.nome as setor, c.matricula  " +
                                "from colaborador c  " +
                                " inner join pessoa p on p.id = c.id_pessoa " +
                                "left join nivel_formacao nf on nf.id = c.id_nivel_formacao " +
                                "inner join cargo ca on ca.id = c.id_cargo " +
                                "left join situacao_colaborador sc on sc.id = c.id_situacao_colaborador " +
                                "left join setor s on s.id = c.id_setor  " +
                                "order by p.nome limit " + ERPViewModelBase.QUANTIDADE_PAGINA + " offset " + offset;

            ((ERPViewModelBase)DataContext).exibirRelatorio("Colaborador", "Colaborador", ConsultaSQL);

        }
    }
}
