using System;
using System.Collections.Generic;

namespace BV212_EF.NET_ADO.DataBase;

public class PrimaryKey
{
    private static readonly Dictionary<Type, int> _lastKeys = new Dictionary<Type, int>();

    public int Key { get; private set; }

    public PrimaryKey(Type type)
    {
        if (!_lastKeys.ContainsKey(type))
        {
            _lastKeys[type] = 0;
        }

        _lastKeys[type]++;
        Key = _lastKeys[type];
    }
}
