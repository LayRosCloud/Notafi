using System;
using System.Collections.Generic;
using NotafiThree.Model.DealData;
using System.Linq;

namespace NotafiThree.Scripts
{
    internal class SortingAdapter
    {
        private List<Service> _sourceServices;
        private List<Service> _sortedServices;
        public SortingAdapter()
        {
            _sourceServices = DataSet.GetServices();
            _sortedServices = new List<Service>(_sourceServices);
        }

        public List<Service> Sort(string text, bool ask)
        {
            FindOnName(text);
            OrderBy(ask);
            return _sortedServices;
        }

        private void FindOnName(string text)
        {
            _sortedServices.Clear();
            _sortedServices.AddRange(_sourceServices);

            _sortedServices = (from x in _sortedServices where x.Title.ToLower().Contains(text.ToLower()) select x).ToList();
        }

        private void OrderBy(bool ask)
        {
            if (ask)
            {
                _sortedServices = (from x in _sortedServices orderby x.Title select x).ToList();
            }
            else
            {
                _sortedServices = (from x in _sortedServices orderby x.Title descending select x).ToList();
            }
        }
    }
}
