namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FMDPJIPCAHP
	{
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(7)] public List<int> Clfodagppmj;
		[ProtoMember(8)] public List<int> BaseAvatarIdList;
	}

}
