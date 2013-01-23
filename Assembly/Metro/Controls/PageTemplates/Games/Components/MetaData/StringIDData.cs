﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assembly.Metro.Controls.PageTemplates.Games.Components.MetaData
{
    public class StringIDData : ValueField
    {
        private int _value;

        public StringIDData(string name, uint offset, int index, uint pluginLine)
            : base(name, offset, pluginLine)
        {
            _value = index;
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; NotifyPropertyChanged("Value"); }
        }

        public override void Accept(IMetaFieldVisitor visitor)
        {
            visitor.VisitStringID(this);
        }

        public override MetaField CloneValue()
        {
            return new StringIDData(Name, Offset, _value, base.PluginLine);
        }
    }
}
