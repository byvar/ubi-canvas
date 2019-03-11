using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackFrameSoundEvents::serialize
	public class AnimTrackFrameSoundEvents {
		public StringID sid;
		public float unk0;
		public uint unk1;

		public AnimTrackFrameSoundEvents(Reader reader) {
			sid = new StringID(reader);
			unk0 = reader.ReadSingle();
			unk1 = reader.ReadUInt32();
		}
	}
}
