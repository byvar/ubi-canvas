using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackBonesList::serialize
	public class AnimTrackBonesList : ICSerializable {
		public ushort unk0;
		public ushort unk1;
		public ushort unk2;
		public ushort unk3;
		
		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref unk0);
			s.Serialize(ref unk1);
			s.Serialize(ref unk2);
			s.Serialize(ref unk3);
		}
	}
}
