using System;
using System.Windows.Markup;
using Autofac;

namespace MVVMExample
{
    public class ViewModelLocatorExtension : MarkupExtension
    {
        public ViewModelLocatorExtension() { }

        public ViewModelLocatorExtension(Type viewModelType) : base()
        {
            this.ViewModelType = viewModelType;
        }

        [ConstructorArgument("ViewModelType")]
        public Type ViewModelType { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return ((App)App.Current).Container.Resolve(ViewModelType);
        }
    }
}
