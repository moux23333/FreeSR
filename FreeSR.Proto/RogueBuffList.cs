namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RogueBuffList
	{
		[ProtoMember(8)] public List<RogueBuff> BuffList;
	}
	
}
