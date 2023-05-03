using System;
using System.Collections.Generic;
using NotafiThree.Model.DealData;
using System.Linq;

namespace NotafiThree.Scripts
{
    internal class SortingAdapter
    {
        private readonly List<Service> _sourceServices;
        private List<Service> _sortedServices;

        public SortingAdapter()
        {
            _sourceServices = DataSet.GetServices();
            _sortedServices = new List<Service>(_sourceServices);
        }

        public List<Service> Sort(string text, bool ask)
        {
			_sortedServices.Clear();
			_sortedServices.AddRange(_sourceServices);
            
			FindOnName(text);
            OrderBy(ask);
            return _sortedServices;
        }

        private void FindOnName(string text)
        {
            string textLower = text.ToLower();

			_sortedServices = (from x in _sortedServices where x.Title.ToLower().Contains(textLower) 
                               || x.Description.ToLower().Contains(textLower) select x).ToList();
        }

        private void OrderBy(bool isAsc)
        {
            if (isAsc)
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
