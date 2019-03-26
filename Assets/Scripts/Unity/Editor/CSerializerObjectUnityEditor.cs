using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace UbiArt {
	public class CSerializerObjectUnityEditor : CSerializerObject {
		private Dictionary<object, bool> foldouts = new Dictionary<object, bool>();
		public uint position = 0;

		private static CSerializerObjectUnityEditor serializer;
		public static CSerializerObjectUnityEditor Serializer {
			get {
				if (serializer == null) {
					serializer = new CSerializerObjectUnityEditor();
					serializer.flags |= SerializeFlags.Flags7;
				}
				return serializer;
			}
		}


		public CSerializerObjectUnityEditor() {
			flagsOwn = Flags.Flags0 | Flags.Flags4; // 0x11
		}

		public override Pointer Position => new Pointer(0, null);
		public override Pointer Length => new Pointer(0, null);
		public override void ResetPosition() {
		}

		public override void Serialize(ref object obj, Type type, string name = null) {
			if (type.IsEnum) {
				if (type.GetCustomAttributes<FlagsAttribute>().Any()) {
					obj = EditorGUILayout.EnumFlagsField(name, (Enum)obj);
				} else {
					obj = EditorGUILayout.EnumPopup(name, (Enum)obj);
				}
			} else if (Type.GetTypeCode(type) != TypeCode.Object) {
				switch (Type.GetTypeCode(type)) {
					case TypeCode.Boolean: obj = EditorGUILayout.Toggle(name, (bool)obj); break;
					case TypeCode.Byte: obj = (byte)EditorGUILayout.IntField(name, (byte)obj); break;
					case TypeCode.Char: obj = (char)EditorGUILayout.IntField(name, (char)obj); break;
					case TypeCode.String: obj = EditorGUILayout.TextField(name, (string)obj); break;
					case TypeCode.Single: obj = EditorGUILayout.FloatField(name, (float)obj); break;
					case TypeCode.Double: obj = EditorGUILayout.DoubleField(name, (double)obj); break;
					case TypeCode.UInt16: obj = (ushort)EditorGUILayout.IntField(name, (ushort)obj); break;
					case TypeCode.UInt32: obj = (uint)EditorGUILayout.LongField(name, (uint)obj); break;
					case TypeCode.UInt64: obj = (ulong)EditorGUILayout.LongField(name, (uint)obj); break;
					case TypeCode.Int16: obj = (short)EditorGUILayout.IntField(name, (short)obj); break;
					case TypeCode.Int32: obj = EditorGUILayout.IntField(name, (int)obj); break;
					case TypeCode.Int64: obj = EditorGUILayout.LongField(name, (long)obj); break;
					default: throw new Exception("Unsupported TypeCode " + Type.GetTypeCode(type));
				}
			} else if (type == typeof(Vector2)) {
				obj = EditorGUILayout.Vector2Field(name, (Vector2)obj);
			} else if (type == typeof(Vector3)) {
				obj = EditorGUILayout.Vector3Field(name, (Vector3)obj);
			} else if (type == typeof(Vector4)) {
				obj = EditorGUILayout.Vector4Field(name, (Vector4)obj);
			} else if (type == typeof(Color)) {
				obj = EditorGUILayout.ColorField(name, (Color)obj);
			} else {
				if (obj == null) {
					var ctor = type.GetConstructor(Type.EmptyTypes);
					if (ctor == null) {
						throw new Exception("Constructor is null");
					}
					obj = ctor.Invoke(new object[] { });
				}
				if (obj is ICSerializable) {
					if (!foldouts.ContainsKey(obj)) {
						foldouts[obj] = false;
					}
					foldouts[obj] = EditorGUILayout.Foldout(foldouts[obj], name, true);
					if (foldouts[obj]) {
						EditorGUI.indentLevel++;
						((ICSerializable)obj).Serialize(this, name);
						EditorGUI.indentLevel--;
					}
				}
			}
		}

		public override void Serialize(object containerObj, FieldInfo f, Type type = null, string name = null, int? index = null) {
			object obj = obj = f.GetValue(containerObj);
			if (type != null) {
				if (type == typeof(byte) && f.FieldType == typeof(bool)) {
					if ((bool)obj) {
						obj = (byte)1;
					} else {
						obj = (byte)0;
					}
				} else if (type == typeof(uint) && f.FieldType == typeof(ObjectRef)) {
					obj = (uint)(ObjectRef)f.GetValue(containerObj);
				}
			}
			Serialize(ref obj, type ?? f.FieldType, name: name);
			if (type != null) {
				if (type == typeof(byte) && f.FieldType == typeof(bool)) {
					if (((byte)obj) == 1) {
						obj = true;
					} else if (((byte)obj) != 0) {
						throw new Exception(Position + ": BoolAsByte with name " + name + " was " + ((byte)obj) + "!");
						obj = false;
					} else {
						obj = false;
					}
				} else if (type == typeof(uint) && f.FieldType == typeof(ObjectRef)) {
					obj = (ObjectRef)(uint)obj;
				}
			}
			f.SetValue(containerObj, obj);
		}

		public override void Serialize(object o, FieldInfo f, SerializeAttribute a, Type type = null) {
			if (((a.version & Settings.s.versionFlags) == Settings.s.versionFlags) && (a.flags == SerializeFlags.None || (flags & a.flags) != SerializeFlags.None)) {
				Serialize(o, f, type: type, name: a.Name);
			}
		}

		public override void Serialize<T>(ref T obj, Type type = null, string name = null, int? index = null) {
			object obj2 = obj;
			Serialize(ref obj2, type ?? typeof(T), name: name);
			obj = (T)obj2;
		}

		public override void SerializeBytes(ref byte[] obj, int numBytes) {
			//obj = reader.ReadBytes(numBytes);
		}
	}
}
