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
			numOffsets = s.Serialize<uint>(numOffsets);
			size = s.Serialize<uint>(size);
			zSize = s.Serialize<uint>(zSize);
			timeStamp = s.Serialize<ulong>(timeStamp);
			if (offsets != null && offsets.Length != numOffsets) {
				Array.Resize(ref offsets, (int)numOffsets);
			} else if (offsets == null) {
				offsets = new ulong[numOffsets];
			}
			for (int i = 0; i < numOffsets; i++) {
				offsets[i] = s.Serialize<ulong>(offsets[i]);
			}
		}
	}
}
