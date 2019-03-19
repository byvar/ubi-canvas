using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DispenserComponent_Template : ActorComponent_Template {
		[Serialize("goodsCount"           )] public uint goodsCount;
		[Serialize("lowLifeGoodsMax"      )] public uint lowLifeGoodsMax;
		[Serialize("lowLifeThreshold"     )] public float lowLifeThreshold;
		[Serialize("dispenseDelay"        )] public float dispenseDelay;
		[Serialize("shakeDelay"           )] public float shakeDelay;
		[Serialize("spawnOffset"          )] public Vector3 spawnOffset;
		[Serialize("isChildLauncher"      )] public bool isChildLauncher;
		[Serialize("animIdle"             )] public StringID animIdle;
		[Serialize("canWiggle"            )] public bool canWiggle;
		[Serialize("padRumbleWiggle"      )] public StringID padRumbleWiggle;
		[Serialize("animWiggle"           )] public StringID animWiggle;
		[Serialize("animDispense"         )] public StringID animDispense;
		[Serialize("animShrink"           )] public StringID animShrink;
		[Serialize("animDone"             )] public StringID animDone;
		[Serialize("animPaint"            )] public StringID animPaint;
		[Serialize("dispenseEvent"        )] public Generic<Event> dispenseEvent;
		[Serialize("dispenseEventPaint"   )] public Generic<Event> dispenseEventPaint;
		[Serialize("lowLifeEvent"         )] public Generic<Event> lowLifeEvent;
		[Serialize("softCollisionDisabled")] public bool softCollisionDisabled;
		[Serialize("softCollision"        )] public RO2_SoftCollision_Template softCollision;
		[Serialize("processStim"          )] public bool processStim;
		[Serialize("processDRCStim"       )] public bool processDRCStim;
		[Serialize("allowNonPlayerHits"   )] public bool allowNonPlayerHits;
		[Serialize("disableWhenDone"      )] public bool disableWhenDone;
		[Serialize("fxStandPaint"         )] public StringID fxStandPaint;
		[Serialize("ejectionAngleList"    )] public Placeholder ejectionAngleList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
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
				SerializeField(s, nameof(animPaint));
				SerializeField(s, nameof(dispenseEvent));
				SerializeField(s, nameof(dispenseEventPaint));
				SerializeField(s, nameof(lowLifeEvent));
				SerializeField(s, nameof(softCollisionDisabled));
				SerializeField(s, nameof(softCollision));
				SerializeField(s, nameof(processStim));
				SerializeField(s, nameof(processDRCStim));
				SerializeField(s, nameof(allowNonPlayerHits));
				SerializeField(s, nameof(disableWhenDone));
				SerializeField(s, nameof(fxStandPaint));
			} else {
				SerializeField(s, nameof(goodsCount));
				SerializeField(s, nameof(lowLifeGoodsMax));
				SerializeField(s, nameof(lowLifeThreshold));
				SerializeField(s, nameof(dispenseDelay));
				SerializeField(s, nameof(shakeDelay));
				SerializeField(s, nameof(spawnOffset));
				SerializeField(s, nameof(isChildLauncher));
				SerializeField(s, nameof(animIdle));
				SerializeField(s, nameof(canWiggle));
				SerializeField(s, nameof(padRumbleWiggle));
				SerializeField(s, nameof(animWiggle));
				SerializeField(s, nameof(animDispense));
				SerializeField(s, nameof(animShrink));
				SerializeField(s, nameof(animDone));
				SerializeField(s, nameof(animPaint));
				SerializeField(s, nameof(dispenseEvent));
				SerializeField(s, nameof(dispenseEventPaint));
				SerializeField(s, nameof(lowLifeEvent));
				SerializeField(s, nameof(softCollisionDisabled));
				SerializeField(s, nameof(softCollision));
				SerializeField(s, nameof(processStim));
				SerializeField(s, nameof(processDRCStim));
				SerializeField(s, nameof(allowNonPlayerHits));
				SerializeField(s, nameof(disableWhenDone));
				SerializeField(s, nameof(fxStandPaint));
			}
		}
		public override uint? ClassCRC => 0x53F1479E;
	}
}

