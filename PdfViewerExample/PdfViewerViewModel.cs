using System.Reflection;
using System.ComponentModel;

namespace PdfViewerExample
{
    /// <summary>
    /// https://help.syncfusion.com/maui/pdf-viewer/getting-started
    /// </summary>
    class PdfViewerViewModel : INotifyPropertyChanged
    {
        private Stream? m_pdfDocumentStream;
        private Stream? m_pdfDocumentStream2;
        private Stream? m_pdfDocumentStream3;

        /// <summary>
        /// An event to detect the change in the value of a property.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
        public event PropertyChangedEventHandler? PropertyChanged2;
        public event PropertyChangedEventHandler? PropertyChanged3;

        /// <summary>
        /// The PDF document stream that is loaded into the instance of the PDF viewer. 
        /// </summary>
        public Stream PdfDocumentStream
        {
            get
            {
                return m_pdfDocumentStream;
            }
            set
            {
                m_pdfDocumentStream = value;
                OnPropertyChanged("PdfDocumentStream");
            }
        }
        public Stream PdfDocumentStream2
        {
            get
            {
                return m_pdfDocumentStream2;
            }
            set
            {
                m_pdfDocumentStream2 = value;
                OnPropertyChanged("PdfDocumentStream2");
            }
        }

        public Stream PdfDocumentStream3
        {
            get
            {
                return m_pdfDocumentStream3;
            }
            set
            {
                m_pdfDocumentStream3 = value;
                OnPropertyChanged("PdfDocumentStream3");
            }
        }

        /// <summary>
        /// Constructor of the view model class
        /// </summary>
        public PdfViewerViewModel()
        {
            //Accessing the PDF document that is added as embedded resource as stream.
            m_pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("PdfViewerExample.Assets.PDF_Succinctly.pdf");
            m_pdfDocumentStream2 = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("PdfViewerExample.Assets.PDF_Succinctlyd.pdf");
            m_pdfDocumentStream3 = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("PdfViewerExample.Assets.PDF_Succinctly.pdf");
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}