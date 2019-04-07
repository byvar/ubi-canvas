using UbiArt.FileFormat.Texture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Bundle {
	public class FileHeaderRuntime : ICSerializable {
		public uint numOffsets;
		public uint size;
		public uint zSize;
		public ulong timeStamp;
		public ulong[] offsets;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref numOffsets);
			s.Serialize(ref size);
			s.Serialize(ref zSize);
			s.Serialize(ref timeStamp);
			if (offsets != null && offsets.Length != numOffsets) {
				Array.Resize(ref offsets, (int)numOffsets);
			} else if (offsets == null) {
				offsets = new ulong[numOffsets];
			}
			for (int i = 0; i < numOffsets; i++) {
				s.Serialize(ref offsets[i]);
			}
		}
	}
}
