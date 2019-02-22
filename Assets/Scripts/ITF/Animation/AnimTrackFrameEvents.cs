using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.Animation {
	// See: ITF::AnimTrackFrameEvents::serialize
	public class AnimTrackFrameEvents {
		public float unk;
		public Container<AnimMarkerEvent> events;

		public AnimTrackFrameEvents(Reader reader) {
			unk = reader.ReadSingle();
			events = new Container<AnimMarkerEvent>(reader);
		}

		public class AnimMarkerEvent {
			public uint type;
			public AnimMarkerEvent(Reader reader) {
				type = reader.ReadUInt32();
			}
		}
	}
}
