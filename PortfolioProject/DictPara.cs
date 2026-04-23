using System;
using System.Collections.Generic;

namespace PortfolioProject
{
    public class DictParaTag
    {
        public string key;
        public object value;
        public bool output;
        public int size;
    }

    public class DictPara : List<Object>
    {
        public void Add(string key, object value)
        {
            Add(key, value, false, 0);
        }

        public void Add(string key, object value, bool output, int size)
        {
            DictParaTag dpt = new DictParaTag();

            dpt.key = key;
            dpt.value = value;
            dpt.output = output;
            dpt.size = size;

            base.Add(dpt);
        }

        public object GetValue(string key)
        {
            foreach (DictParaTag dpt in this)
            {
                if (dpt.key == key)
                {
                    return dpt.value;
                }
            }
            return null;
        }

        public void SetValue(string key, string value)
        {
            foreach (DictParaTag dpt in this)
            {
                if (dpt.key == key)
                {
                    dpt.value = value;
                }
            }
        }
    }
}
