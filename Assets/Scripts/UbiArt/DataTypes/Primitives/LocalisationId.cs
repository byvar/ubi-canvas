﻿using I18N.Common;
using System;

namespace UbiArt {
	public class LocalisationId : ICSerializable, IEquatable<LocalisationId>, ICSerializableShortLog {
		public uint id = 0xFFFFFFFF;

		public LocalisationId() { }
		public LocalisationId(uint id) { this.id = id; }

		public void Serialize(CSerializerObject s, string name) {
			id = s.Serialize<uint>(id);
		}

		public const int Invalid = -1;
		public const int Empty = 0;

		public bool IsNull {
			get {
				return id == 0xFFFFFFFF;
			}
		}
		public static implicit operator LocalisationId(uint i) {
			return new LocalisationId(i);
		}

		public override string ToString() => $"LocId({id})";

		public string ToString(Context c) {
			string str = ToString();
			if (c.Loader?.localisation != null && c.Loader.localisation.strings[0].ContainsKey(id)) {
				str += $" - {c.Loader.localisation.strings[0][id].text.Replace("\n", "\\n")}";
			}
			return str;
		}

		public override bool Equals(object obj) {
			return obj is LocalisationId && this == (LocalisationId)obj;
		}
		public override int GetHashCode() {
			return id.GetHashCode();
		}

		public bool Equals(LocalisationId other) {
			return this == (LocalisationId)other;
		}

		public string SerializeLog(CSerializerObject s) => ToString(s?.Context);

		public static bool operator ==(LocalisationId x, LocalisationId y) {
			if (ReferenceEquals(x, y)) return true;
			if (ReferenceEquals(x, null)) return false;
			if (ReferenceEquals(y, null)) return false;
			return x.id == y.id;
		}
		public static bool operator !=(LocalisationId x, LocalisationId y) {
			return !(x == y);
		}


		// Casts
		public static implicit operator LocalisationId(StringID sid) {
			return new LocalisationId(sid.stringID);
		}
		public static implicit operator StringID(LocalisationId lid) {
			return new StringID(lid.id);
		}
	}
}
