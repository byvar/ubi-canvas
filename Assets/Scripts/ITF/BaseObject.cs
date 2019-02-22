using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class BaseObject {
		public uint sizeOf;
		public BaseObject(Reader reader) {
			if ((reader.flags & Reader.Flags.AddObjectSizes) != 0) {
				sizeOf = reader.ReadUInt32();
			}
			var fields = from field in GetType().GetFields()
						 where Attribute.IsDefined(field, typeof(SerializeAttribute))
						 let attr = ((SerializeAttribute)field
								   .GetCustomAttributes(typeof(SerializeAttribute), false)
								   .Single())
						 where attr.game == Settings.Game.None || attr.game == Settings.s.game
						 orderby attr.Order
						 orderby field.DeclaringType.GetParentTypes().Count() ascending
						 select field;

			foreach (var field in fields) {
				var attr = ((SerializeAttribute)field.GetCustomAttributes(typeof(SerializeAttribute), false).Single());
				object obj;
				if (Type.GetTypeCode(field.FieldType) != TypeCode.Object) {
					switch (Type.GetTypeCode(field.FieldType)) {
						case TypeCode.Boolean: obj = (object)reader.ReadBoolean(); break;
						case TypeCode.Byte: obj = (object)reader.ReadByte(); break;
						case TypeCode.Char: obj = (object)reader.ReadChar(); break;
						case TypeCode.String: obj = (object)reader.ReadString(); break;
						case TypeCode.Single: obj = (object)reader.ReadSingle(); break;
						case TypeCode.Double: obj = (object)reader.ReadDouble(); break;
						case TypeCode.UInt16: obj = (object)reader.ReadUInt16(); break;
						case TypeCode.UInt32: obj = (object)reader.ReadUInt32(); break;
						case TypeCode.UInt64: obj = (object)reader.ReadUInt64(); break;
						case TypeCode.Int16: obj = (object)reader.ReadInt16(); break;
						case TypeCode.Int32: obj = (object)reader.ReadInt32(); break;
						case TypeCode.Int64: obj = (object)reader.ReadInt64(); break;
						default: throw new Exception("Unsupported TypeCode " + Type.GetTypeCode(field.FieldType));
					}
				} else if (field.FieldType == typeof(Vector2)) {
					obj = reader.ReadVector2();
				} else if (field.FieldType == typeof(Vector3)) {
					obj = reader.ReadVector3();
				} else if (field.FieldType == typeof(Vector4)) {
					obj = reader.ReadVector4();
				} else if (field.FieldType == typeof(Color)) {
					obj = reader.ReadColor();
				} else {
					var ctor = field.FieldType.GetConstructor(new Type[] { typeof(Reader) });
					obj = ctor.Invoke(new object[] { reader });
				}
				field.SetValue(this, obj);
			}
		}
	}
}
