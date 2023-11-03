using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using UbiCanvas.Helpers;

namespace UbiArt {
	public class CSerializerObjectUnityEditor : CSerializerObject {
		private Dictionary<object, bool> foldouts = new Dictionary<object, bool>();
		public uint position = 0;
		private LocalisationIdDropdown localisationDropdown = null;
		private GenericClassSelectorDropdown genericDropdown = null;

		private static CSerializerObjectUnityEditor serializer;
		public static CSerializerObjectUnityEditor Serializer(Context context) {
			if(serializer != null && serializer.Context != context)
				serializer = null;

			if (serializer == null) {
				serializer = new CSerializerObjectUnityEditor(context);
				serializer.flags |= SerializeFlags.Flags7;
			}

			return serializer;
		}


		public CSerializerObjectUnityEditor(Context context) : base(context) {
			properties = SerializerProperty.Binary | SerializerProperty.Flags4; // 0x11
		}

		public override Pointer CurrentPointer => new Pointer(CurrentPosition, null);
		public override long CurrentPosition => 0;
		public override long Length => 0;

		public override void Serialize(ref object obj, Type type, string name = null) {
			if (name == null) name = $"({type.GetFormattedName()})";
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
			} else if (type == typeof(ITF.ObjectPath)) {
				ITF.ObjectPath p = (ITF.ObjectPath)obj;
				DrawObjectPath(name, ref p);
				obj = p;
			} else if (type == typeof(StringID)) {
				StringID sid = (StringID)obj;
				DrawStringID(name, ref sid);
				obj = sid;
			} else if (type == typeof(LocalisationId)) {
				LocalisationId locId = (LocalisationId)obj;
				DrawLocId(name, ref locId);
				obj = locId;
			} else if (type == typeof(Vec2d)) {
				obj = (Vec2d)(EditorGUILayout.Vector2Field(name, ((Vec2d)obj ?? new Vec2d()).GetUnityVector()).GetUbiArtVector());
			} else if (type == typeof(Vec3d)) {
				obj = (Vec3d)(EditorGUILayout.Vector3Field(name, ((Vec3d)obj ?? new Vec3d()).GetUnityVector()).GetUbiArtVector());
			} else if (type == typeof(Vec4d)) {
				obj = (Vec4d)(EditorGUILayout.Vector4Field(name, ((Vec4d)obj ?? new Vec4d()).GetUnityVector()).GetUbiArtVector());
			} else if (type == typeof(Color)) {
				obj = (Color)(EditorGUILayout.ColorField(name, ((Color)obj ?? new Color()).GetUnityColor()).GetUbiArtColor());
			} else if (type == typeof(ColorInteger)) {
				obj = (ColorInteger)(EditorGUILayout.ColorField(name, ((ColorInteger)obj ?? new ColorInteger()).GetUnityColor()).GetUbiArtColorInteger());
			} else if (type == typeof(CString)) {
				obj = new CString(EditorGUILayout.TextField(name, ((CString)obj ?? new CString()).str));
			} else if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Generic<>)){
				var t = type.GetGenericArguments()[0];
				IGeneric gen = (IGeneric)obj;
				DrawGenericClassSelector(name, ref gen, type, t);
				obj = gen;
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

		public override byte[] SerializeBytes(byte[] obj, long count) {
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
		public void DrawObjectPath(string name, ref ITF.ObjectPath p) {
			if (p == null) p = new ITF.ObjectPath();
			//EditorGUILayout.PrefixLabel(name);
			Rect rect = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight);
			//texPreviewRect = EditorGUI.PrefixLabel(texPreviewRect, new GUIContent(name));
			string fullPath = p.FullPath;
			//var indent = EditorGUI.indentLevel;
			//EditorGUI.indentLevel = 0;
			string newPath = EditorGUI.TextField(rect, new GUIContent(name), fullPath);
			//EditorGUI.indentLevel = indent;
			if (newPath != fullPath) {
				p = new ITF.ObjectPath(newPath);
			}
		}
		public void DrawStringID(string name, ref StringID sid) {
			if (sid == null) sid = new StringID();
			var context = Controller.MainContext;
			//EditorGUILayout.PrefixLabel(name);
			Rect rect = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight);
			rect = EditorGUI.PrefixLabel(rect, new GUIContent(name));

			var indent = EditorGUI.indentLevel;
			EditorGUI.indentLevel = 0;

			var sidWidth = EditorGUIUtility.singleLineHeight * 5;
			var sidRect = new Rect(rect.position, new Vector2(sidWidth, rect.height));
			var strRect = new Rect(rect.position + new Vector2(sidWidth, 0), new Vector2(rect.width - sidWidth, rect.height));

			// Draw StringID UI (hex)
			var curSidHex = $"{sid.stringID:X8}";
			var newSidHex = EditorGUI.DelayedTextField(sidRect, curSidHex);
			if (curSidHex != newSidHex) {
				if (uint.TryParse(newSidHex, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out uint newHex)) {
					sid = new StringID(newHex);
				}
			}

			// Draw StringID UI (string)
			bool useString = context.StringCache.ContainsKey(sid);
			if (!useString) {
				if (GUI.Button(strRect, new GUIContent("Use string input"))) {
					sid = new StringID("");
					context.AddToStringCache("");
				}
			} else {
				var curSidStr = context.StringCache.TryGetItem(sid, "");
				var newSidStr = EditorGUI.TextField(strRect, curSidStr);
				if (curSidStr != newSidStr) {
					sid = new StringID(newSidStr);
					context.AddToStringCache(newSidStr);
				}
			}

			EditorGUI.indentLevel = indent;
		}
		public void DrawLocId(string name, ref LocalisationId locId) {
			if (locId == null) locId = new LocalisationId();
			Rect rect = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight);
			rect = EditorGUI.PrefixLabel(rect, new GUIContent(name));

			
			int indent = EditorGUI.indentLevel;
			var localisation = Controller.MainContext.Loader.localisation;
			string locIdPreview = locId.IsNull ? "-1 - " : locId.id + " - ";
			if (locId.IsNull) {
				locIdPreview += "None";
			} else if (locId.id == 0) {
				locIdPreview += "Empty";
			} else if (localisation != null && localisation.strings.Count > 0 && localisation.strings[0].ContainsKey(locId)) {
				locIdPreview += localisation.strings[0][locId].text.Replace("\n","\\n");
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

		public void DrawGenericClassSelector(string name, ref IGeneric gen, Type genType, Type t) {
			if (gen == null) {
				var ctor = genType.GetConstructor(Type.EmptyTypes);
				if (ctor == null) {
					throw new Exception("Constructor is null");
				}
				gen = (IGeneric)ctor.Invoke(new object[] { });
			}

			if (!foldouts.ContainsKey(gen)) {
				foldouts[gen] = false;
			}
			foldouts[gen] = EditorGUILayout.Foldout(foldouts[gen], name, true);
			if (!foldouts[gen]) return;
			// Increase indent level
			EditorGUI.indentLevel++;
			IncreaseLevel();

			Rect rect = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight);
			rect = EditorGUI.PrefixLabel(rect, new GUIContent(name));

			var genTypeName = t.GetFormattedName();


			int indent = EditorGUI.indentLevel;
			string genPreview;
			if (gen.IsNull) {
				genPreview = "None";
			} else {
				Type type = ObjectFactory.classes[gen.GenericClassName.stringID];
				genPreview = type.GetFormattedName();
			}

			EditorGUI.indentLevel = 0;
			if (EditorGUI.DropdownButton(rect, new GUIContent(genPreview), FocusType.Passive)) {
				if (genericDropdown == null || genericDropdown.type != t) {
					genericDropdown = new GenericClassSelectorDropdown(new UnityEditor.IMGUI.Controls.AdvancedDropdownState()) {
						name = $"Generic<{genTypeName}>",
						type = t
					};
				}
				genericDropdown.rect = rect;
				genericDropdown.Show(rect);
			}
			if (genericDropdown != null && genericDropdown.selection != null && genericDropdown.rect == rect) {
				var newGenID = genericDropdown.selection.Value;
				genericDropdown.selection = null;

				if (newGenID != gen.GenericClassName?.stringID) {
					// Create new object
					/*var newType = ObjectFactory.classes[newGenID];
					if (newType.ContainsGenericParameters) {
						if (!genType.IsGenericType) {
							EditorGUI.indentLevel = indent;
							return; // Don't make this change
						}
						newType = newType.MakeGenericType(genType.GetGenericArguments());
					}*/
					gen.GenericClassName = new StringID(newGenID);
					gen.GenericObject = null;
				}
			}

			EditorGUI.indentLevel = indent;

			if (!gen.IsNull) {
				gen.SerializeObject(this);
			}

			// Decrease indent level
			DecreaseLevel();
			EditorGUI.indentLevel--;

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
			if(name == null) name = $"({type.GetFormattedName()})";
			if (type == typeof(Path)) {
				Path p = (Path)(object)obj;
				DrawPath(name, ref p);
				obj = (T)(object)p;
			} else if (type == typeof(ITF.ObjectPath)) {
				ITF.ObjectPath p = (ITF.ObjectPath)(object)obj;
				DrawObjectPath(name, ref p);
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
				obj = (T)(object)(Vec2d)(EditorGUILayout.Vector2Field(name, ((Vec2d)(object)obj ?? new Vec2d()).GetUnityVector()).GetUbiArtVector());
			} else if (type == typeof(Vec3d)) {
				obj = (T)(object)(Vec3d)(EditorGUILayout.Vector3Field(name, ((Vec3d)(object)obj ?? new Vec3d()).GetUnityVector()).GetUbiArtVector());
			} else if (type == typeof(Vec4d)) {
				obj = (T)(object)(Vec4d)(EditorGUILayout.Vector4Field(name, ((Vec4d)(object)obj ?? new Vec4d()).GetUnityVector()).GetUbiArtVector());
			} else if (type == typeof(Color)) {
				obj = (T)(object)(Color)(EditorGUILayout.ColorField(name, ((Color)(object)obj ?? new Color()).GetUnityColor()).GetUbiArtColor());
			} else if (type == typeof(ColorInteger)) {
				obj = (T)(object)(ColorInteger)(EditorGUILayout.ColorField(name, ((ColorInteger)(object)obj ?? new ColorInteger()).GetUnityColor()).GetUbiArtColorInteger());

			} else if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Generic<>)) {
				var t = type.GetGenericArguments()[0];
				IGeneric gen = (IGeneric)(object)obj;
				DrawGenericClassSelector(name, ref gen, type, t);
				obj = (T)(object)gen;
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

		public override void Log(string logString, params object[] args) { }

		protected override void DoEncoded(IStreamEncoder encoder, Action action, Endian? endianness = null, string filename = null) {
			if (action == null)
				throw new ArgumentNullException(nameof(action)); 
			action();
		}

		public override void DoEncrypted(uint[] encryptionKey, Action action, string name = null) {
			if (action == null)
				throw new ArgumentNullException(nameof(action));
			action();
		}

		public override void DoCompressed(Action action, string name = null) {
			if (action == null)
				throw new ArgumentNullException(nameof(action));
			action();
		}

		public override void DoEndian(Action action, Endian endianness) {
			if (action == null)
				throw new ArgumentNullException(nameof(action));
			action();
		}

		public override bool SerializeEditorButton(string name) {
			return GUILayout.Button(name);
		}
	}
}
