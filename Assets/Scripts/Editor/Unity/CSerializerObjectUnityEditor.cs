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
		private LocalisationIdDropdown localisationDropdown = null;

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
			} else if (type == typeof(Path)) {
				Path p = (Path)obj;
				DrawPath(name, ref p);
				obj = p;
			} else if (type == typeof(StringID)) {
				StringID sid = (StringID)obj;
				DrawStringID(name, ref sid);
				obj = sid;
			} else if(type == typeof(LocalisationId)) {
				LocalisationId locId = (LocalisationId)obj;
				DrawLocId(name, ref locId);
				obj = locId;
			} else if (type == typeof(Vec2d)) {
				obj = (Vec2d)EditorGUILayout.Vector2Field(name, (Vec2d)obj);
			} else if (type == typeof(Vec3d)) {
				obj = (Vec3d)EditorGUILayout.Vector3Field(name, (Vec3d)obj);
			} else if (type == typeof(Vector4)) {
				obj = (Vector4)EditorGUILayout.Vector4Field(name, (Vector4)obj);
			} else if (type == typeof(Color)) {
				obj = (Color)EditorGUILayout.ColorField(name, (Color)obj);
			} else if (type == typeof(ColorInteger)) {
				obj = (ColorInteger)EditorGUILayout.ColorField(name, (ColorInteger)obj);
			} else if (type == typeof(CString)) {
				obj = new CString(EditorGUILayout.TextField(name, ((CString)obj).str));
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
						IncreaseLevel();
						((ICSerializable)obj).Serialize(this, name);
						DecreaseLevel();
						EditorGUI.indentLevel--;
					}
				}
			}
		}

		public override void Serialize(object containerObj, FieldInfo f, Type type = null, string name = null, int? index = null) {
			object obj = obj = f.GetValue(containerObj);
			if (type != null) ConvertTypeBefore(ref obj, name, type, f.FieldType);
			Serialize(ref obj, type ?? f.FieldType, name: name);
			if (type != null) ConvertTypeAfter(ref obj, name, type, f.FieldType);
			f.SetValue(containerObj, obj);
		}

		public override T SerializeGeneric<T>(T obj, Type type = null, string name = null, int? index = null) {
			object obj2 = obj;
			Serialize(ref obj2, type ?? typeof(T), name: name);
			return (T)obj2;
		}

		public override byte[] SerializeBytes(byte[] obj, int numBytes) {
			//obj = reader.ReadBytes(numBytes);
			return obj;
		}

		public override uint SerializeFileSize(uint obj) {
			//throw new NotImplementedException();
			return obj;
		}

		public void DrawPath(string name, ref Path p) {
			if (p == null) p = new Path();
			//EditorGUILayout.PrefixLabel(name);
			Rect rect = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight);
			//texPreviewRect = EditorGUI.PrefixLabel(texPreviewRect, new GUIContent(name));
			string fullPath = p.FullPath;
			//var indent = EditorGUI.indentLevel;
			//EditorGUI.indentLevel = 0;
			string newPath = EditorGUI.TextField(rect, new GUIContent(name), fullPath);
			//EditorGUI.indentLevel = indent;
			if (newPath != fullPath) {
				p = new Path(newPath);
			}
		}
		public void DrawStringID(string name, ref StringID sid) {
			if (sid == null) sid = new StringID();
			//EditorGUILayout.PrefixLabel(name);
			Rect rect = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight);
			//texPreviewRect = EditorGUI.PrefixLabel(texPreviewRect, new GUIContent(name));
			/*string str = null;
			if (MapLoader.Loader.stringCache.ContainsKey(sid)) {
				str = MapLoader.Loader.stringCache[sid];
			}*/
			string stringIdToString = sid.ToString();
			//EditorGUI.BeginDisabledGroup(true);
			string newStringID = EditorGUI.TextField(rect, new GUIContent(name), stringIdToString);
			//EditorGUI.EndDisabledGroup();
		}
		public void DrawLocId(string name, ref LocalisationId locId) {
			if (locId == null) locId = new LocalisationId();
			Rect rect = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight);
			rect = EditorGUI.PrefixLabel(rect, new GUIContent(name));

			
			int indent = EditorGUI.indentLevel;
			string locIdPreview = locId.IsNull ? "-1 - " : locId.id + " - ";
			if (locId.IsNull) {
				locIdPreview += "None";
			} else if (locId.id == 0) {
				locIdPreview += "Empty";
			} else if (MapLoader.Loader.localisation != null && MapLoader.Loader.localisation.strings.Count > 0 && MapLoader.Loader.localisation.strings[0].ContainsKey(locId)) {
				locIdPreview += MapLoader.Loader.localisation.strings[0][locId].text.Replace("\n","\\n");
			} else {
				locIdPreview += "Error";
			}

			EditorGUI.indentLevel = 0;
			if (EditorGUI.DropdownButton(rect, new GUIContent(locIdPreview), FocusType.Passive)) {
				if (localisationDropdown == null) {
					localisationDropdown = new LocalisationIdDropdown(new UnityEditor.IMGUI.Controls.AdvancedDropdownState()) {
						name = "Localisation ID"
					};
				}
				localisationDropdown.rect = rect;
				localisationDropdown.Show(rect);
			}
			if (localisationDropdown != null && localisationDropdown.selection != null && localisationDropdown.rect == rect) {
				locId = localisationDropdown.selection;
				localisationDropdown.selection = null;
			}

			EditorGUI.indentLevel = indent;
		}

		public override T SerializeGenericPureBinary<T>(T obj, Type type = null, string name = null, int? index = null) {
			return SerializeGeneric<T>(obj, type: type, name: name, index: index);
		}

		// Helper method which returns an object so we can cast it
		protected object SerializePrimitiveAsObject<T>(object obj, string name = null, Options options = Options.None) {
			// Get the type
			var type = typeof(T);

			TypeCode typeCode = Type.GetTypeCode(type);

			if (type.IsEnum) {
				if (type.GetCustomAttributes<FlagsAttribute>().Any()) {
					obj = EditorGUILayout.EnumFlagsField(name, (Enum)obj);
				} else {
					obj = EditorGUILayout.EnumPopup(name, (Enum)obj);
				}
			} else if (typeCode == TypeCode.Object) {
				if (type == typeof(CString)) {
					obj = new CString(EditorGUILayout.TextField(name, ((CString)obj).str));
				}
			} else {
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
			}
			return obj;
		}


		public override T Serialize<T>(T obj, string name = null, int? index = null, Options options = Options.None) {
			T t = (T)SerializePrimitiveAsObject<T>(obj, name: name, options: options);
			return t;
		}

		public override T SerializeObject<T>(T obj, Action<T> onPreSerialize = null, string name = null, int? index = null, Options options = Options.None) {
			// Get the type
			var type = typeof(T);
			if (type == typeof(Path)) {
				Path p = (Path)(object)obj;
				DrawPath(name, ref p);
				obj = (T)(object)p;
			} else if (type == typeof(StringID)) {
				StringID sid = (StringID)(object)obj;
				DrawStringID(name, ref sid);
				obj = (T)(object)sid;
			} else if (type == typeof(LocalisationId)) {
				LocalisationId locId = (LocalisationId)(object)obj;
				DrawLocId(name, ref locId);
				obj = (T)(object)locId;
			} else if (type == typeof(Vec2d)) {
				obj = (T)(object)(Vec2d)EditorGUILayout.Vector2Field(name, (Vec2d)(object)obj);
			} else if (type == typeof(Vec3d)) {
				obj = (T)(object)(Vec3d)EditorGUILayout.Vector3Field(name, (Vec3d)(object)obj);
			} else if (type == typeof(Vec4d)) {
				obj = (T)(object)(Vec4d)EditorGUILayout.Vector4Field(name, (Vec4d)(object)obj);
			} else if (type == typeof(Color)) {
				obj = (T)(object)(Color)EditorGUILayout.ColorField(name, (Color)(object)obj);
			} else if (type == typeof(ColorInteger)) {
				obj = (T)(object)(ColorInteger)EditorGUILayout.ColorField(name, (ColorInteger)(object)obj);
			} else {
				if (obj == null) {
					obj = new T();
				}
				if (!foldouts.ContainsKey(obj)) {
					foldouts[obj] = false;
				}
				foldouts[obj] = EditorGUILayout.Foldout(foldouts[obj], name, true);
				if (foldouts[obj]) {
					EditorGUI.indentLevel++;
					IncreaseLevel();
					obj.Serialize(this, name);
					DecreaseLevel();
					EditorGUI.indentLevel--;
				}
			}

			return obj;
		}

	}
}
