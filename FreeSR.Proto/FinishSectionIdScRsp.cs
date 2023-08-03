namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishSectionIdScRsp
	{
		[ProtoMember(6)] public ItemList Reward;
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(11)] public int SectionId;
	}
	
}
