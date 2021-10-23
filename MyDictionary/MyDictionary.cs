using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<T, K>
    {
       
        T[] _key;
        K[] _value;


        T[] _tempKey; //önceki kullanıcları tutabilmesi için temp array ataması yapıyoruz.
        K[] _tempValue; //önceki kullanıcları tutabilmesi için temp array ataması yapıyoruz.


        public MyDictionary()
        {
            _key = new T[0];
            _value = new K[0];
        }

      
        public void Add(T key, K value)
        {
            T[] _tempKey = _key;
            K[] _tempValue = _value;

            _key = new T[_tempKey.Length + 1];  //eleman sayısını alıyoruz
            _value = new K[_tempValue.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++) //for içerisinde eleman sayısı kadar devam ediyor
            {
                _key[i] = _tempKey[i];
                _value[i] = _tempValue[i];
            }
            _key[_key.Length - 1] = key; //gerçek eleman sayısını bulabilmek için 1 çkıkartıyoruz. Çunku 0 dan başlarız.
            _value[_value.Length - 1] = value;

            Console.WriteLine("Key: "+key+ "    " + "Value: "+value ); ;
        }

    }
}
