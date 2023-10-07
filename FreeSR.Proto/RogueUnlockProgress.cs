namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RogueUnlockProgress
	{
		[ProtoMember(13)] public int UnlockId;
		[ProtoMember(6)] public int Progress;
		[ProtoMember(14)] public bool Finish;
	}

}
