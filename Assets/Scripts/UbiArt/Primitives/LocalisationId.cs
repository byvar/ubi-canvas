using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class LocalisationId : ICSerializable, IEquatable<LocalisationId> {
		public uint id = 0xFFFFFFFF;

		public LocalisationId() { }
		public LocalisationId(uint id) { this.id = id; }

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize<uint>(ref id);
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

		public override string ToString() {
			string mainStr = "LocId(" + id + ")";
			if (MapLoader.Loader.localisation != null && MapLoader.Loader.localisation.strings[0].ContainsKey(id)) {
				mainStr += " - " + MapLoader.Loader.localisation.strings[0][id].text.Replace("\n", "\\n");
			}
			return mainStr;
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

		public static bool operator ==(LocalisationId x, LocalisationId y) {
			if (ReferenceEquals(x, y)) return true;
			if (ReferenceEquals(x, null)) return false;
			if (ReferenceEquals(y, null)) return false;
			return x.id == y.id;
		}
		public static bool operator !=(LocalisationId x, LocalisationId y) {
			return !(x == y);
		}
	}
}
