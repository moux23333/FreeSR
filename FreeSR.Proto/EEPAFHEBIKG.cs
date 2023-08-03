namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EEPAFHEBIKG
	{
		[ProtoMember(2)] public int MonsterId;
		[ProtoMember(8)] public int MaxHp;
		[ProtoMember(1)] public int CurHp;
	}
	
}
