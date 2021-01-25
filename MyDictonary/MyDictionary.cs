using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class MyDictionaryy<TKey, TValeu>
    {
        TKey[] keyArray;
        TValeu[] valeuArray;

        TKey[] tempKeyArray;
        TValeu[] tempValeuArray;
        public MyDictionaryy()
        {
            keyArray = new TKey[0];
            valeuArray = new TValeu[0];
        }
        public void Add(TKey key, TValeu valeu)
        {
            keyArray = new TKey[keyArray.Length + 1];
            valeuArray = new TValeu[valeuArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];

            }
            for (int i = 0; i < tempValeuArray.Length; i++)
            {
                valeuArray[i] = tempValeuArray[i];
            }

            keyArray[keyArray.Length - 1] = key;
            valeuArray[valeuArray.Length - 1] = valeu;
        }

        public TKey []  Items1 
        { 
            get { return keyArray; }
        }
        public TValeu [] Items2 
        { 
        get { return valeuArray; }
        }
    }



       

       
              
        
    }

}
