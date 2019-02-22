using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Generic<T> : BaseObject {
		[Serialize(0, "$ClassName$")] public StringID className;
		public T obj;
		
		public Generic(Reader reader) : base(reader) {
			if (ClassCRC.classes.ContainsKey(className.stringID)) {
				MapLoader.Loader.print(className.stringID.ToString("X8") + " - " + ClassCRC.classes[className.stringID]);
				var ctor = ClassCRC.classes[className.stringID].GetConstructor(new Type[] { typeof(Reader) });
				obj = (T)ctor.Invoke(new object[] { reader });
			} else {
				Debug.LogError("CRC " + className.stringID.ToString("X8")
					+ " found at " + Pointer.Current(reader)
					+ " while reading container of type " + typeof(T) + " is not yet supported!");
				throw new NotImplementedException("CRC " + className.stringID.ToString("X8")
					+ " found at position " + Pointer.Current(reader)
					+ " while reading container of type " + typeof(T) + " is not yet supported!");
			}
		}
	}
}
