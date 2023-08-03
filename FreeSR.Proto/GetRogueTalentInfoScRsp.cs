namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetRogueTalentInfoScRsp
	{
		[ProtoMember(11)] public int Retcode;
		[ProtoMember(9)] public DHOKDGIIAPB JPBHDKKGONJ;
	}
	
}
