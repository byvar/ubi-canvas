using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class Link : ICSerializable {
		public uint stringID;
		public void Serialize(CSerializerObject s, string name) {
			stringID = s.Serialize<uint>(stringID);
		}

		public override string ToString() {
			return "Link(" + stringID + ")";
		}
		
		public override int GetHashCode() {
			return stringID.GetHashCode();
		}

		public override bool Equals(object obj) {
			if (obj == null || GetType() != obj.GetType())
				return false;

			Link other = obj as Link;
			return stringID == other.stringID;
		}
		public bool Equals(Link other) {
			return this == (Link)other;
		}

		public static bool operator ==(Link x, Link y) {
			if (ReferenceEquals(x, y)) return true;
			if (ReferenceEquals(x, null)) return false;
			if (ReferenceEquals(y, null)) return false;
			return x.stringID == y.stringID;
		}
		public static bool operator !=(Link x, Link y) {
			return !(x == y);
		}
	}
}
