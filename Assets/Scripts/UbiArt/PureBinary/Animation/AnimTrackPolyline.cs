using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackPolyline::serialize
	public class AnimTrackPolyline {
		public float unk;
		public CList<StringID> entries;

		public AnimTrackPolyline(Reader reader) {
			unk = reader.ReadSingle();
			entries = new CList<StringID>(reader);
		}
	}
}
