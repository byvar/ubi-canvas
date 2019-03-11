using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackBonesList::serialize
	public class AnimTrackBonesList {
		public ushort unk0;
		public ushort unk1;
		public ushort unk2;
		public ushort unk3;

		public AnimTrackBonesList(Reader reader) {
			unk0 = reader.ReadUInt16();
			unk1 = reader.ReadUInt16();
			unk2 = reader.ReadUInt16();
			unk3 = reader.ReadUInt16();
		}
	}
}
