using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventReceivePlayAnimComponent_Template : ActorComponent_Template {
		[Serialize("phantomShape"        )] public Generic<PhysShape> phantomShape;
		[Serialize("watchEvent"          )] public Generic<Event> watchEvent;
		[Serialize("resetStartValueEvent")] public Generic<Event> resetStartValueEvent;
		[Serialize("phantomOffset"       )] public Vector2 phantomOffset;
		[Serialize("speedIncrease"       )] public float speedIncrease;
		[Serialize("decrease"            )] public float decrease;
		[Serialize("maxSpeed"            )] public float maxSpeed;
		[Serialize("minSpeed"            )] public float minSpeed;
		[Serialize("resetTimeMin"        )] public float resetTimeMin;
		[Serialize("resetTimeMax"        )] public float resetTimeMax;
		[Serialize("resetDelay"          )] public float resetDelay;
		[Serialize("lockOnEnd"           )] public bool lockOnEnd;
		[Serialize("useSingleEvent"      )] public bool useSingleEvent;
		[Serialize("bounceFactor"        )] public float bounceFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(phantomShape));
			SerializeField(s, nameof(watchEvent));
			SerializeField(s, nameof(resetStartValueEvent));
			SerializeField(s, nameof(phantomOffset));
			SerializeField(s, nameof(speedIncrease));
			SerializeField(s, nameof(decrease));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(minSpeed));
			SerializeField(s, nameof(resetTimeMin));
			SerializeField(s, nameof(resetTimeMax));
			SerializeField(s, nameof(resetDelay));
			SerializeField(s, nameof(lockOnEnd));
			SerializeField(s, nameof(useSingleEvent));
			SerializeField(s, nameof(bounceFactor));
		}
		public override uint? ClassCRC => 0xAB971CA8;
	}
}

