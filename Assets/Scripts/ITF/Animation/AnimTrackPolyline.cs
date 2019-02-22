using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.Animation {
	// See: ITF::AnimTrackPolyline::serialize
	public class AnimTrackPolyline {
		public float unk;
		public Container<StringID> entries;

		public AnimTrackPolyline(Reader reader) {
			unk = reader.ReadSingle();
			entries = new Container<StringID>(reader);
		}
	}
}
