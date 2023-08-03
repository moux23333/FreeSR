namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RogueUnlockProgress
	{
		[ProtoMember(5)] public int UnlockId;
		[ProtoMember(9)] public bool Finish;
		[ProtoMember(8)] public int Progress;
	}
	
}
