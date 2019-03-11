using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class StringID : ICSerializable {
		public uint stringID;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize<uint>(ref stringID);
		}

		public bool IsNull {
			get {
				return stringID == 0xFFFFFFFF;
			}
		}

		public override int GetHashCode() {
			return stringID.GetHashCode();
		}

		public override bool Equals(object obj) {
			if (obj == null || GetType() != obj.GetType())
				return false;

			StringID other = obj as StringID;
			return stringID == other.stringID;
		}

		public StringID() {
			stringID = 0xFFFFFFFF;
		}

		public StringID(string str) : this(ASCIIEncoding.ASCII.GetBytes(str)) {}
		public StringID(byte[] array) {
			uint v3; // r4@1
			uint pos; // r9@1
			uint left; // r10@1
			uint v6; // r6@1
			uint i; // r5@1
			uint v8; // r8@2
			uint v9; // r7@3
			uint v12; // r5@3
			uint v13; // r7@3
			uint v15; // r5@3
			uint v17; // r7@3
			uint v20; // r4@3
			uint v21; // r7@3
			uint v23; // r4@3
			uint v25; // r8@3
			uint v28; // r7@3
			uint v29; // r6@3
			uint v31; // r0@3
			uint v32; // r5@3
			uint v33; // r4@3
			uint v34; // r3@3
			uint v35; // r5@3
			uint v36; // r4@3
			uint v37; // r3@3
			uint v38; // r6@4
			uint v39; // r2@16
			uint v40; // r3@16
			uint v41; // r0@16
			uint v42; // r2@16
			uint v43; // r3@16
			uint v44; // r0@16
			uint v45; // r2@16
			
			v3 = 0x9E3779B9;
			pos = 0;
			left = (uint)array.Length;
			v6 = 0;
			for (i = 0x9E3779B9; ; v6 = (v37 - i - v3) ^ (v3 >> 15)) {
				v8 = pos;
				pos += 12;
				if (left < 12)
					break;
				left -= 12;
				v9 = ToUp(array[pos - 12]);
				v12 = v9 + i + (ToUp(array[pos - 11]) << 8);
				v13 = ToUp(array[pos - 10]);
				v15 = v12 + (v13 << 16) + (ToUp(array[pos - 9]) << 24);
				v17 = ToUp(array[pos - 8]);
				v20 = v17 + v3 + (ToUp(array[pos - 7]) << 8);
				v21 = ToUp(array[pos - 6]);
				v23 = v20 + (v21 << 16) + (ToUp(array[pos - 5]) << 24);
				v25 = ToUp(array[pos - 4]);
				v28 = v25 + v6 + (ToUp(array[pos - 3]) << 8);
				v29 = ToUp(array[pos - 2]);
				v31 = v28 + (v29 << 16) + (ToUp(array[pos - 1]) << 24);
				v32 = (v15 - v23 - v31) ^ (v31 >> 13);
				v33 = (v23 - v31 - v32) ^ (v32 << 8);
				v34 = (v31 - v32 - v33) ^ (v33 >> 13);
				v35 = (v32 - v33 - v34) ^ (v34 >> 12);
				v36 = (v33 - v34 - v35) ^ (v35 << 16);
				v37 = (v34 - v35 - v36) ^ (v36 >> 5);
				i = (v35 - v36 - v37) ^ (v37 >> 3);
				v3 = (v36 - v37 - i) ^ (i << 10);
			}
			v38 = v6 + (uint)array.Length;
			if (left < 12) {
				if (left >= 11) v38 += ToUp(array[v8 + 10]) << 24;
				if (left >= 10) v38 += ToUp(array[v8 + 9]) << 16;
				if (left >= 9) v38 += ToUp(array[v8 + 8]) << 8;
				if (left >= 8) v3 += ToUp(array[v8 + 7]) << 24;
				if (left >= 7) v3 += ToUp(array[v8 + 6]) << 16;
				if (left >= 6) v3 += ToUp(array[v8 + 5]) << 8;
				if (left >= 5) v3 += ToUp(array[v8 + 4]);
				if (left >= 4) i += ToUp(array[v8 + 3]) << 24;
				if (left >= 3) i += ToUp(array[v8 + 2]) << 16;
				if (left >= 2) i += ToUp(array[v8 + 1]) << 8;
				if (left >= 1) i += ToUp(array[v8]);
			}
			v39 = (i - v3 - v38) ^ (v38 >> 13);
			v40 = (v3 - v38 - v39) ^ (v39 << 8);
			v41 = (v38 - v39 - v40) ^ (v40 >> 13);
			v42 = (v39 - v40 - v41) ^ (v41 >> 12);
			v43 = (v40 - v41 - v42) ^ (v42 << 16);
			v44 = (v41 - v42 - v43) ^ (v43 >> 5);
			v45 = (v42 - v43 - v44) ^ (v44 >> 3);
			stringID = (v44 - v45 - ((v43 - v44 - v45) ^ (v45 << 10))) ^ (((v43 - v44 - v45) ^ (v45 << 10)) >> 15);
		}
		static uint ToUp(uint result) {
			if (result > 97 && result <= 97 + 0x19) {
				result = result - 32;
			}
			return result;
		}
	}
}
