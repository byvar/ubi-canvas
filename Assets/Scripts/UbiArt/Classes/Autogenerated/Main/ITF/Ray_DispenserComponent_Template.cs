using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_DispenserComponent_Template : ActorComponent_Template {
		[Serialize("goodsCount"           )] public uint goodsCount;
		[Serialize("lowLifeGoodsMax"      )] public uint lowLifeGoodsMax;
		[Serialize("lowLifeThreshold"     )] public float lowLifeThreshold;
		[Serialize("dispenseDelay"        )] public float dispenseDelay;
		[Serialize("shakeDelay"           )] public float shakeDelay;
		[Serialize("spawnOffset"          )] public Vec3d spawnOffset;
		[Serialize("ejectionAngleList"    )] public CArray<Angle> ejectionAngleList;
		[Serialize("isChildLauncher"      )] public int isChildLauncher;
		[Serialize("animIdle"             )] public StringID animIdle;
		[Serialize("canWiggle"            )] public int canWiggle;
		[Serialize("padRumbleWiggle"      )] public StringID padRumbleWiggle;
		[Serialize("animWiggle"           )] public StringID animWiggle;
		[Serialize("animDispense"         )] public StringID animDispense;
		[Serialize("animShrink"           )] public StringID animShrink;
		[Serialize("animDone"             )] public StringID animDone;
		[Serialize("dispenseEvent"        )] public Generic<Event> dispenseEvent;
		[Serialize("lowLifeEvent"         )] public Generic<Event> lowLifeEvent;
		[Serialize("softCollisionDisabled")] public int softCollisionDisabled;
		[Serialize("softCollision"        )] public Ray_SoftCollision_Template softCollision;
		[Serialize("processStim"          )] public int processStim;
		[Serialize("allowNonPlayerHits"   )] public int allowNonPlayerHits;
		[Serialize("disableWhenDone"      )] public int disableWhenDone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(goodsCount));
			SerializeField(s, nameof(lowLifeGoodsMax));
			SerializeField(s, nameof(lowLifeThreshold));
			SerializeField(s, nameof(dispenseDelay));
			SerializeField(s, nameof(shakeDelay));
			SerializeField(s, nameof(spawnOffset));
			SerializeField(s, nameof(ejectionAngleList));
			SerializeField(s, nameof(isChildLauncher));
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(canWiggle));
			SerializeField(s, nameof(padRumbleWiggle));
			SerializeField(s, nameof(animWiggle));
			SerializeField(s, nameof(animDispense));
			SerializeField(s, nameof(animShrink));
			SerializeField(s, nameof(animDone));
			SerializeField(s, nameof(dispenseEvent));
			SerializeField(s, nameof(lowLifeEvent));
			SerializeField(s, nameof(softCollisionDisabled));
			SerializeField(s, nameof(softCollision));
			SerializeField(s, nameof(processStim));
			SerializeField(s, nameof(allowNonPlayerHits));
			SerializeField(s, nameof(disableWhenDone));
		}
		public override uint? ClassCRC => 0xDE07C31D;
	}
}

