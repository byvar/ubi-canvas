﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class MaskResolverComponent : ActorComponent {
		[Serialize(0, "clearFrontLightBuffer")]                         public bool clearFrontLightBuffer;
		[Serialize(1, "clearFrontLightColor")]                          public Color clearFrontLightColor;
		[Serialize(2, "clearBackLightBuffer")]                          public bool clearBackLightBuffer;
		[Serialize(3, "clearBackLightColor")]                           public Color clearBackLightColor;
		[Serialize(4, "blurFrontLightBuffer", game = Settings.Game.RL)] public bool blurFrontLightBuffer;
		[Serialize(5, "blurBackLightBuffer", game = Settings.Game.RL)]  public bool blurBackLightBuffer;
		[Serialize(6, "blurQuality", game = Settings.Game.RL)]          public uint blurQuality;
		[Serialize(7, "blurSize", game = Settings.Game.RL)]             public uint blurSize;
		[Serialize(7, "blurSize", game = Settings.Game.RA)]             public float blurSizeAdventures;

		public MaskResolverComponent(Reader reader) : base(reader) {
			var fields = from field in GetType().GetFields()
						 where Attribute.IsDefined(field, typeof(SerializeAttribute))
						 let attr = ((SerializeAttribute)field
								   .GetCustomAttributes(typeof(SerializeAttribute), false)
								   .Single())
						 where attr.game == Settings.Game.None || attr.game == Settings.s.game
						 orderby attr.Order
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
