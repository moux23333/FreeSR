namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class CHPNMFBCGPL
	{
        //[ProtoMember(4)] public HealthBarInfo CurHealth;
        [ProtoMember(4)] public int Id;
        [ProtoMember(12)] public int Hp;
		[ProtoMember(9)] public AvatarType AvatarType;
	}

}
