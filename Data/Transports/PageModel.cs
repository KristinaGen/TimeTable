﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Transports
{
    public class PageModel: IModel
    {
        public List<IModel> List { get; set; }

        public PageModel()
        {
            List = new List<IModel>();
        }

        public void Add(IModel m)
        {
            List.Add(m);
        }

        public void Remove(IModel m)
        {
            List.Remove(m);
        }

        public IModel GetChild(int i)
        {
            return List[i];
        }

        public void Operation()
        {
            foreach (var model in List)
            {
                model.Operation();
            }

        }
    }
}
