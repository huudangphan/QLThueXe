PGDMP     $    -                 z            MyDB    13.4    13.4 g               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16394    MyDB    DATABASE     g   CREATE DATABASE "MyDB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Vietnamese_Vietnam.1258';
    DROP DATABASE "MyDB";
                postgres    false                        0    0    SCHEMA public    ACL     P   GRANT USAGE ON SCHEMA public TO boss;
GRANT USAGE ON SCHEMA public TO employee;
                   postgres    false    3            ?            1259    16422    khach    TABLE     ?   CREATE TABLE public.khach (
    cmnd character varying(13) NOT NULL,
    ten character varying(40),
    dia_chi character varying(50),
    sdt character(12),
    ngay_sinh date,
    anh character varying(50)
);
    DROP TABLE public.khach;
       public         heap    postgres    false            !           0    0    TABLE khach    ACL        GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.khach TO boss;
GRANT SELECT,INSERT,UPDATE ON TABLE public.khach TO employee;
          public          postgres    false    203            ?            1255    16520 f   get_khach(character varying, character varying, character varying, character, date, character varying)    FUNCTION     ?  CREATE FUNCTION public.get_khach(_cmnd character varying DEFAULT ''::character varying, _ten character varying DEFAULT ''::character varying, _dia_chi character varying DEFAULT ''::character varying, _sdt character DEFAULT ''::bpchar, _ngay_sinh date DEFAULT '0001-01-01'::date, _anh character varying DEFAULT ''::character varying) RETURNS SETOF public.khach
    LANGUAGE plpgsql
    AS $$
begin
	--PERFORM pg_sleep(10);
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
	return query select * from khach where
				(cmnd=_cmnd or _cmnd='') and(ten=_ten or _ten='') and
				(dia_chi=_dia_chi or _dia_chi='') and (sdt=_sdt or _sdt='') and
				(ngay_sinh=_ngay_sinh or _ngay_sinh='1/1/0001');
				
	
end
$$;
 ?   DROP FUNCTION public.get_khach(_cmnd character varying, _ten character varying, _dia_chi character varying, _sdt character, _ngay_sinh date, _anh character varying);
       public          postgres    false    203            "           0    0 ?   FUNCTION get_khach(_cmnd character varying, _ten character varying, _dia_chi character varying, _sdt character, _ngay_sinh date, _anh character varying)    ACL     ?   GRANT ALL ON FUNCTION public.get_khach(_cmnd character varying, _ten character varying, _dia_chi character varying, _sdt character, _ngay_sinh date, _anh character varying) TO boss;
          public          postgres    false    238            ?            1255    57620    insert_bao_hanh(date)    FUNCTION     ?  CREATE FUNCTION public.insert_bao_hanh(_ngay date DEFAULT '0001-01-01'::date) RETURNS integer
    LANGUAGE plpgsql
    AS $$
declare _stt int default 0;
declare _id_phieu char(10) default '';
begin
	_stt=(select max(stt) from bao_hanh);
	_stt=_stt+1;
	_id_phieu= _stt::text ||'bhanh' || _stt::text; 	
	insert into bao_hanh(id_phieu,ngay) values(_id_phieu,_ngay)	;
	return 200;
	
end
$$;
 2   DROP FUNCTION public.insert_bao_hanh(_ngay date);
       public          postgres    false            ?            1255    49353 O   insert_ct_hop_dong(character varying, double precision, integer, date, integer)    FUNCTION     r  CREATE FUNCTION public.insert_ct_hop_dong(_bien_so_hd character varying DEFAULT ''::character varying, _gia_thue double precision DEFAULT 1, _so_ngay_thue integer DEFAULT 1, _ngay_tra date DEFAULT '0001-01-01'::date, _km_hien_tai integer DEFAULT 0) RETURNS integer
    LANGUAGE plpgsql
    AS $$
declare _id_hop_dong char(30);
_tong_tien double precision; _stt int;
begin
	
	if( _bien_so_hd='') then
		return 100;
	end if;	
	_stt=(select max(stt) from hop_dong);
	_id_hop_dong=(select id_hop_dong from hop_dong where stt=_stt);	
	
	_tong_tien=(_gia_thue * _so_ngay_thue);
	insert into ct_hop_dong(bien_so_hd,gia_thue,so_ngay_thue,tong_tien,ngay_tra,km_hien_tai,status,km_tra,id_hop_dong)
	values(_bien_so_hd,_gia_thue,_so_ngay_thue,_tong_tien,_ngay_tra,_km_hien_tai,'false',_km_hien_tai,_id_hop_dong);
		
	update xe set status=true where bien_so=_bien_so_hd;
	return 200;
	
end
$$;
 ?   DROP FUNCTION public.insert_ct_hop_dong(_bien_so_hd character varying, _gia_thue double precision, _so_ngay_thue integer, _ngay_tra date, _km_hien_tai integer);
       public          postgres    false            #           0    0 ?   FUNCTION insert_ct_hop_dong(_bien_so_hd character varying, _gia_thue double precision, _so_ngay_thue integer, _ngay_tra date, _km_hien_tai integer)    ACL     ?   GRANT ALL ON FUNCTION public.insert_ct_hop_dong(_bien_so_hd character varying, _gia_thue double precision, _so_ngay_thue integer, _ngay_tra date, _km_hien_tai integer) TO boss;
          public          postgres    false    246            ?            1255    57622 @   insert_ct_phieu_bao_hanh(character, double precision, character)    FUNCTION     ]  CREATE FUNCTION public.insert_ct_phieu_bao_hanh(_bien_so character DEFAULT ''::bpchar, _chi_phi double precision DEFAULT 0, _ghi_chu character DEFAULT ''::bpchar) RETURNS integer
    LANGUAGE plpgsql
    AS $$
declare _stt int default 0;
declare _id_phieu char(10) default '';
begin
	_stt=(select max(stt) from bao_hanh);	
	_id_phieu= (select id_phieu from bao_hanh where stt=_stt); 	
	if exists (select 1 from xe where bien_so =_bien_so) then
	
		insert into ct_phieu_bao_hanh(id_phieu,bien_so,chi_phi,ghi_chu)
		values(_id_phieu,_bien_so,_chi_phi,_ghi_chu);
		return 200;
	end if;
	return 19;
	
end
$$;
 r   DROP FUNCTION public.insert_ct_phieu_bao_hanh(_bien_so character, _chi_phi double precision, _ghi_chu character);
       public          postgres    false            ?            1255    49338 2   insert_hop_dong(date, character, double precision)    FUNCTION     P  CREATE FUNCTION public.insert_hop_dong(_ngay_thue date DEFAULT '0001-01-01'::date, _cmnd character DEFAULT ''::bpchar, _tien_coc double precision DEFAULT 0) RETURNS integer
    LANGUAGE plpgsql
    AS $$
declare _id_hop_dong char(30) default '';
declare _stt int default 0;
declare _stt2 char default '';
begin
	_stt=(select max(stt) from hop_dong);
	_stt=_stt+2;
	_stt2=cast(_stt as char);
	_id_hop_dong= _cmnd::text ||'hd' || _stt::text; 	
	insert into hop_dong(ngay_thue,cmnd,tien_coc,id_hop_dong,tra_coc)
	values(_ngay_thue,_cmnd,_tien_coc,_id_hop_dong,'False');		
	return 200;
	
end
$$;
 d   DROP FUNCTION public.insert_hop_dong(_ngay_thue date, _cmnd character, _tien_coc double precision);
       public          postgres    false            $           0    0 V   FUNCTION insert_hop_dong(_ngay_thue date, _cmnd character, _tien_coc double precision)    ACL     t   GRANT ALL ON FUNCTION public.insert_hop_dong(_ngay_thue date, _cmnd character, _tien_coc double precision) TO boss;
          public          postgres    false    244            ?            1255    16519 i   insert_khach(character varying, character varying, character varying, character, date, character varying)    FUNCTION     ?  CREATE FUNCTION public.insert_khach(_cmnd character varying DEFAULT ''::character varying, _ten character varying DEFAULT ''::character varying, _dia_chi character varying DEFAULT ''::character varying, _sdt character DEFAULT ''::bpchar, _ngay_sinh date DEFAULT '0001-01-01'::date, _anh character varying DEFAULT ''::character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	if exists(select 1 from khach where cmnd=_cmnd) then
		return 100;
	end if;
	if(_cmnd='') then
		return 101;
	end if;
	insert into khach(cmnd,ten,dia_chi,sdt,ngay_sinh,anh)
	values(_cmnd,_ten,_dia_chi,_sdt,_ngay_sinh,_anh);
			
	return 200;
	
end
$$;
 ?   DROP FUNCTION public.insert_khach(_cmnd character varying, _ten character varying, _dia_chi character varying, _sdt character, _ngay_sinh date, _anh character varying);
       public          postgres    false            %           0    0 ?   FUNCTION insert_khach(_cmnd character varying, _ten character varying, _dia_chi character varying, _sdt character, _ngay_sinh date, _anh character varying)    ACL     ?   GRANT ALL ON FUNCTION public.insert_khach(_cmnd character varying, _ten character varying, _dia_chi character varying, _sdt character, _ngay_sinh date, _anh character varying) TO boss;
          public          postgres    false    239            ?            1255    57659 5   insert_phan_cong(character, character, date, integer)    FUNCTION     ?  CREATE FUNCTION public.insert_phan_cong(_tai_xe character DEFAULT 'tu_lai'::bpchar, _bien_so_hd character DEFAULT ''::bpchar, _from_date date DEFAULT '0001-01-01'::date, _so_ngay integer DEFAULT 1) RETURNS integer
    LANGUAGE plpgsql
    AS $$
declare _id_hop_dong char(30);
_to_date date ;
_stt integer;
begin
	
	_stt=(select max(stt) from hop_dong);
	_id_hop_dong=(select id_hop_dong from hop_dong where stt=_stt);	
	_to_date=_so_ngay + _from_date;
	insert into phan_cong(tai_xe,bien_so_hd,id_hop_dong,from_date,to_date)
	values(_tai_xe,_bien_so_hd,_id_hop_dong,_from_date,_to_date);
	update taixe
	set status='true'
	where cmnd=_tai_xe;
	return 200;
	
end
$$;
 t   DROP FUNCTION public.insert_phan_cong(_tai_xe character, _bien_so_hd character, _from_date date, _so_ngay integer);
       public          postgres    false            ?            1255    57656 (   insert_taixe(character, character, date)    FUNCTION     ?  CREATE FUNCTION public.insert_taixe(_cmnd character DEFAULT '1'::bpchar, _ten_tx character DEFAULT ''::bpchar, _ngay_sinh date DEFAULT '0001-01-01'::date) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	if exists(select 1 from taixe where cmnd=_cmnd) then
		return 100;
	end if;
	insert into taixe(cmnd,ten_tx,ngay_sinh,status)
	values(_cmnd,_ten_tx,_ngay_sinh,'false');
	return 200;
	
end
$$;
 X   DROP FUNCTION public.insert_taixe(_cmnd character, _ten_tx character, _ngay_sinh date);
       public          postgres    false            ?            1255    16515 f   insert_xe(character varying, integer, character varying, double precision, character varying, boolean)    FUNCTION     ?  CREATE FUNCTION public.insert_xe(_bien_so character varying DEFAULT ''::character varying, _id_hang integer DEFAULT '-1'::integer, _ten_xe character varying DEFAULT ''::character varying, _gia_thue double precision DEFAULT '-1'::integer, _ma_kiem_soat character varying DEFAULT ''::character varying, _status boolean DEFAULT true) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	if exists(select 1 from xe where bien_so=_bien_so)then
		return 100;
	end if;
	if  exists(select 1 from hang_xe where id_hang=_id_hang) then
		insert into xe(bien_so,id_hang,ten_xe,gia_thue,ma_kiem_soat,status)
		values(_bien_so,_id_hang,_ten_xe,_gia_thue,_ma_kiem_soat,_status);
		return 200;
	end if;
	return 200;
	
end
$$;
 ?   DROP FUNCTION public.insert_xe(_bien_so character varying, _id_hang integer, _ten_xe character varying, _gia_thue double precision, _ma_kiem_soat character varying, _status boolean);
       public          postgres    false            &           0    0 ?   FUNCTION insert_xe(_bien_so character varying, _id_hang integer, _ten_xe character varying, _gia_thue double precision, _ma_kiem_soat character varying, _status boolean)    ACL     ?   GRANT ALL ON FUNCTION public.insert_xe(_bien_so character varying, _id_hang integer, _ten_xe character varying, _gia_thue double precision, _ma_kiem_soat character varying, _status boolean) TO boss;
          public          postgres    false    234            ?            1259    57595    bao_hanh    TABLE     o   CREATE TABLE public.bao_hanh (
    stt integer NOT NULL,
    id_phieu character(10) NOT NULL,
    ngay date
);
    DROP TABLE public.bao_hanh;
       public         heap    postgres    false            ?            1255    57624    search_bao_hanh()    FUNCTION     ?   CREATE FUNCTION public.search_bao_hanh() RETURNS SETOF public.bao_hanh
    LANGUAGE plpgsql
    AS $$
begin
	
	return query select * from bao_hanh
					;
	
	
	
end
$$;
 (   DROP FUNCTION public.search_bao_hanh();
       public          postgres    false    211            ?            1259    57600    ct_phieu_bao_hanh    TABLE     ?   CREATE TABLE public.ct_phieu_bao_hanh (
    id_phieu character(10) NOT NULL,
    bien_so character(15),
    chi_phi double precision,
    ghi_chu character(500)
);
 %   DROP TABLE public.ct_phieu_bao_hanh;
       public         heap    postgres    false            ?            1255    57625    search_ct_bao_hanh(character)    FUNCTION     ?   CREATE FUNCTION public.search_ct_bao_hanh(_id_phieu character DEFAULT ''::bpchar) RETURNS SETOF public.ct_phieu_bao_hanh
    LANGUAGE plpgsql
    AS $$
begin
	
	return query select * from ct_phieu_bao_hanh where id_phieu=_id_phieu;
	
	
	
end
$$;
 >   DROP FUNCTION public.search_ct_bao_hanh(_id_phieu character);
       public          postgres    false    212            ?            1255    57592 "   search_ct_hop_dong_byid(character)    FUNCTION     l  CREATE FUNCTION public.search_ct_hop_dong_byid(id character DEFAULT ''::bpchar) RETURNS TABLE(id_hop_dong character, ngay_thue date, ngay_tra date, tinh_trang boolean, bien_so_hd character varying, gia_thue double precision, so_ngay_thue integer, tong_tien double precision, status boolean, km_hien_tai integer)
    LANGUAGE plpgsql
    AS $$
begin
	return query 
		select hd.id_hop_dong,hd.ngay_thue,ct.ngay_tra,ct.status,ct.bien_so_hd,ct.gia_thue,ct.so_ngay_thue,ct.tong_tien,ct.status,ct.km_hien_tai
		from hop_dong hd join ct_hop_dong ct on hd.id_hop_dong=ct.id_hop_dong where hd.id_hop_dong =id;		
		
					
end
$$;
 <   DROP FUNCTION public.search_ct_hop_dong_byid(id character);
       public          postgres    false            ?            1259    49384    hoa_don    TABLE     ?   CREATE TABLE public.hoa_don (
    id_hop_dong character(30) NOT NULL,
    bien_so_hd character(15) NOT NULL,
    id_phieu_phat integer,
    tong_tien double precision
);
    DROP TABLE public.hoa_don;
       public         heap    postgres    false            '           0    0    TABLE hoa_don    ACL     <   GRANT SELECT,DELETE,UPDATE ON TABLE public.hoa_don TO boss;
          public          postgres    false    209            ?            1255    49401    search_hoa_don(character)    FUNCTION     ?   CREATE FUNCTION public.search_hoa_don(_id_hop_dong character DEFAULT ''::bpchar) RETURNS SETOF public.hoa_don
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select * from hoa_don where id_hop_dong=_id_hop_dong;
	
	
end
$$;
 =   DROP FUNCTION public.search_hoa_don(_id_hop_dong character);
       public          postgres    false    209            (           0    0 /   FUNCTION search_hoa_don(_id_hop_dong character)    ACL     M   GRANT ALL ON FUNCTION public.search_hoa_don(_id_hop_dong character) TO boss;
          public          postgres    false    242            ?            1255    49402 $   search_hoa_don(character, character)    FUNCTION     )  CREATE FUNCTION public.search_hoa_don(_id_hop_dong character DEFAULT ''::bpchar, _bien_so_hd character DEFAULT ''::bpchar) RETURNS SETOF public.hoa_don
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select * from hoa_don where id_hop_dong=_id_hop_dong and bien_so_hd=_bien_so_hd;
	
	
end
$$;
 T   DROP FUNCTION public.search_hoa_don(_id_hop_dong character, _bien_so_hd character);
       public          postgres    false    209            )           0    0 F   FUNCTION search_hoa_don(_id_hop_dong character, _bien_so_hd character)    ACL     d   GRANT ALL ON FUNCTION public.search_hoa_don(_id_hop_dong character, _bien_so_hd character) TO boss;
          public          postgres    false    228            ?            1259    16453    hop_dong    TABLE     ?   CREATE TABLE public.hop_dong (
    ngay_thue date,
    cmnd character varying(13),
    tien_coc double precision,
    id_hop_dong character(30) NOT NULL,
    stt integer NOT NULL,
    tra_coc boolean
);
    DROP TABLE public.hop_dong;
       public         heap    postgres    false            *           0    0    TABLE hop_dong    ACL     ?   GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.hop_dong TO boss;
GRANT SELECT,INSERT,UPDATE ON TABLE public.hop_dong TO employee;
          public          postgres    false    204            ?            1255    49350    search_hop_dong(character)    FUNCTION     %  CREATE FUNCTION public.search_hop_dong(_cmnd character DEFAULT ''::bpchar) RETURNS SETOF public.hop_dong
    LANGUAGE plpgsql
    AS $$
begin
	if(_cmnd='') then
	return query select * from hop_dong
					;
	else
		return query select * from hop_dong
					where cmnd=_cmnd;
	end if;
	
	
end
$$;
 7   DROP FUNCTION public.search_hop_dong(_cmnd character);
       public          postgres    false    204            +           0    0 )   FUNCTION search_hop_dong(_cmnd character)    ACL     G   GRANT ALL ON FUNCTION public.search_hop_dong(_cmnd character) TO boss;
          public          postgres    false    240            ?            1255    49345 2   search_hop_dong(date, character, double precision)    FUNCTION     ?  CREATE FUNCTION public.search_hop_dong(_ngay_thue date DEFAULT '0001-01-01'::date, _cmnd character DEFAULT ''::bpchar, _tien_coc double precision DEFAULT 0) RETURNS SETOF public.hop_dong
    LANGUAGE plpgsql
    AS $$
begin
	return query select * from hop_dong
					where (ngay_thue='0001-01-01' or ngay_thue=_ngay_thue) and (cmnd='' or cmnd=_cmnd) 
					and (tien_coc=0 or tien_coc=_tien_coc);
	
end
$$;
 d   DROP FUNCTION public.search_hop_dong(_ngay_thue date, _cmnd character, _tien_coc double precision);
       public          postgres    false    204            ,           0    0 V   FUNCTION search_hop_dong(_ngay_thue date, _cmnd character, _tien_coc double precision)    ACL     t   GRANT ALL ON FUNCTION public.search_hop_dong(_ngay_thue date, _cmnd character, _tien_coc double precision) TO boss;
          public          postgres    false    243            ?            1259    16495 
   phieu_phat    TABLE     ?   CREATE TABLE public.phieu_phat (
    id_phieu_phat integer NOT NULL,
    id_hop_dong character(30),
    so_ngay_tre integer,
    tong_tien_phat double precision,
    km_tre integer,
    bien_so_hd character(15)
);
    DROP TABLE public.phieu_phat;
       public         heap    postgres    false            -           0    0    TABLE phieu_phat    ACL     ?   GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.phieu_phat TO boss;
GRANT SELECT,INSERT ON TABLE public.phieu_phat TO employee;
          public          postgres    false    207            ?            1255    49363 !   search_phieu_phat_byid(character)    FUNCTION     ?   CREATE FUNCTION public.search_phieu_phat_byid(_id character DEFAULT 1) RETURNS SETOF public.phieu_phat
    LANGUAGE plpgsql
    AS $$
begin
	return query 
	select * from phieu_phat where id_hop_dong=_id;
					
end
$$;
 <   DROP FUNCTION public.search_phieu_phat_byid(_id character);
       public          postgres    false    207            .           0    0 .   FUNCTION search_phieu_phat_byid(_id character)    ACL     L   GRANT ALL ON FUNCTION public.search_phieu_phat_byid(_id character) TO boss;
          public          postgres    false    227            ?            1255    49403    search_phieu_phat_byid(integer)    FUNCTION     ?   CREATE FUNCTION public.search_phieu_phat_byid(_id integer DEFAULT 1) RETURNS SETOF public.phieu_phat
    LANGUAGE plpgsql
    AS $$
begin
	return query 
	select * from phieu_phat where id_phieu_phat=_id;
					
end
$$;
 :   DROP FUNCTION public.search_phieu_phat_byid(_id integer);
       public          postgres    false    207            /           0    0 ,   FUNCTION search_phieu_phat_byid(_id integer)    ACL     J   GRANT ALL ON FUNCTION public.search_phieu_phat_byid(_id integer) TO boss;
          public          postgres    false    247            ?            1259    16412    xe    TABLE     ?   CREATE TABLE public.xe (
    bien_so character varying(15) NOT NULL,
    id_hang integer,
    ten_xe character varying(20),
    gia_thue double precision,
    ma_kiem_soat character varying(10),
    status boolean
);
    DROP TABLE public.xe;
       public         heap    postgres    false            0           0    0    TABLE xe    ACL     r   GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.xe TO boss;
GRANT SELECT,INSERT ON TABLE public.xe TO employee;
          public          postgres    false    202            ?            1255    16516 f   search_xe(character varying, integer, character varying, double precision, character varying, boolean)    FUNCTION     ?  CREATE FUNCTION public.search_xe(_bien_so character varying DEFAULT ''::character varying, _id_hang integer DEFAULT '-1'::integer, _ten_xe character varying DEFAULT ''::character varying, _gia_thue double precision DEFAULT '-1'::integer, _ma_kiem_soat character varying DEFAULT ''::character varying, _status boolean DEFAULT true) RETURNS SETOF public.xe
    LANGUAGE plpgsql
    AS $$
begin
	

	--SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
	return query select * from xe
				where (bien_so=_bien_so or _bien_so='') and(id_hang=_id_hang or _id_hang=-1)
				and (ten_xe=_ten_xe or _ten_xe='') and (gia_thue=_gia_thue or _gia_thue=-1)
				and (ma_kiem_soat=_ma_kiem_soat or _ma_kiem_soat ='') ;
	--PERFORM pg_sleep(10);
	
	
end
$$;
 ?   DROP FUNCTION public.search_xe(_bien_so character varying, _id_hang integer, _ten_xe character varying, _gia_thue double precision, _ma_kiem_soat character varying, _status boolean);
       public          postgres    false    202            1           0    0 ?   FUNCTION search_xe(_bien_so character varying, _id_hang integer, _ten_xe character varying, _gia_thue double precision, _ma_kiem_soat character varying, _status boolean)    ACL     ?   GRANT ALL ON FUNCTION public.search_xe(_bien_so character varying, _id_hang integer, _ten_xe character varying, _gia_thue double precision, _ma_kiem_soat character varying, _status boolean) TO boss;
          public          postgres    false    241            ?            1255    49310    test2(integer)    FUNCTION     ?   CREATE FUNCTION public.test2(v integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	--SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	insert into test2(a,b) values(1,v) ;
		PERFORM pg_sleep(10);	
	return 200;
	
end
$$;
 '   DROP FUNCTION public.test2(v integer);
       public          postgres    false            2           0    0    FUNCTION test2(v integer)    ACL     7   GRANT ALL ON FUNCTION public.test2(v integer) TO boss;
          public          postgres    false    229            ?            1255    49359 .   update_hop_dong(character, integer, character)    FUNCTION     ?  CREATE FUNCTION public.update_hop_dong(_id_hop_dong character DEFAULT ''::bpchar, _km_tra integer DEFAULT 1, _bien_so_hd character DEFAULT ''::bpchar) RETURNS integer
    LANGUAGE plpgsql
    AS $$
declare _so_ngay_tre integer DEFAULT 0;
declare _ngay_thue date default '0001-01-01';
declare _tien_phat integer default 0;
declare _so_ngay_thue integer default 0;
declare _ngay_tra  date default CURRENT_DATE ;
declare _km_thue integer default 0;
declare _km_chenh_lech integer default 0;
declare _tien_hoa_don double precision default 0;
declare _tien_thue double precision default 0;
declare _id_phieu_phat integer default 0;
begin 
	
		update ct_hop_dong
		set ngay_tra=CURRENT_DATE ,status=true
		where id_hop_dong=_id_hop_dong and bien_so_hd=_bien_so_hd;
		
		update ct_hop_dong
		set status=true
		where id_hop_dong=_id_hop_dong and bien_so_hd=_bien_so_hd;
		
		_ngay_thue=(select ngay_thue from hop_dong where id_hop_dong=_id_hop_dong);
		_so_ngay_thue=(select so_ngay_thue from ct_hop_dong where id_hop_dong=_id_hop_dong and bien_so_hd=_bien_so_hd);
		_so_ngay_tre=_ngay_tra - _ngay_thue;
		_km_thue=(select km_hien_tai from ct_hop_dong where id_hop_dong=_id_hop_dong and bien_so_hd=_bien_so_hd);
		_km_chenh_lech = _km_tra-_km_thue;
		if(_so_ngay_tre>_so_ngay_thue and _km_chenh_lech <500) then
			_tien_phat = _so_ngay_tre * 100000;
			insert into phieu_phat(id_hop_dong,so_ngay_tre,tong_tien_phat,km_tre,bien_so_hd)
			values(_id_hop_dong,_so_ngay_tre,_tien_phat,0,_bien_so_hd);
		end if;
		if(_so_ngay_tre<_so_ngay_thue and _km_chenh_lech >500) then
			_tien_phat = _km_chenh_lech * 10000;
			insert into phieu_phat(id_hop_dong,so_ngay_tre,tong_tien_phat,km_tre,bien_so_hd)
			values(_id_hop_dong,_so_ngay_tre,_tien_phat,_km_chenh_lech,_bien_so_hd);
		end if;
		if(_so_ngay_tre>_so_ngay_thue and _km_chenh_lech >500) then
			_tien_phat = (_km_chenh_lech * 100000)+(_so_ngay_tre * 120000);
			insert into phieu_phat(id_hop_dong,so_ngay_tre,tong_tien_phat,km_tre,bien_so_hd)
			values(_id_hop_dong,_so_ngay_tre,_tien_phat,_km_chenh_lech,_bien_so_hd);
		end if;

	
	_tien_thue=(select gia_thue from ct_hop_dong where bien_so_hd=_bien_so_hd and id_hop_dong = _id_hop_dong);
	_tien_thue=_tien_thue*_so_ngay_thue;
	if exists(select 1 from phieu_phat where id_hop_dong=_id_hop_dong and bien_so_hd=_bien_so_hd ) then
		_tien_thue=_tien_thue+_tien_phat;
		_id_phieu_phat=(select id_phieu_phat from phieu_phat where id_hop_dong=_id_hop_dong and bien_so_hd=_bien_so_hd);
		insert into hoa_don(id_hop_dong,bien_so_hd,id_phieu_phat,tong_tien)
		values(_id_hop_dong,_bien_so_hd,_id_phieu_phat,_tien_thue);
	else	
		insert into hoa_don(id_hop_dong,bien_so_hd,tong_tien)
		values(_id_hop_dong,_bien_so_hd,_tien_thue);
	end if;
	update xe set status='false' where bien_so=_bien_so_hd;
	update taixe set status='false'
	where cmnd in(select tai_xe from phan_cong where bien_so_hd=_bien_so_hd and bien_so_hd=_bien_so_hd);
	return 200;
	update ct_hop_dong set km_tra = _km_tra where id_hop_dong=_id_hop_dong and bien_so_hd=_bien_so_hd;
end
$$;
 f   DROP FUNCTION public.update_hop_dong(_id_hop_dong character, _km_tra integer, _bien_so_hd character);
       public          postgres    false            3           0    0 X   FUNCTION update_hop_dong(_id_hop_dong character, _km_tra integer, _bien_so_hd character)    ACL     v   GRANT ALL ON FUNCTION public.update_hop_dong(_id_hop_dong character, _km_tra integer, _bien_so_hd character) TO boss;
          public          postgres    false    245            ?            1255    16514 .   update_xe(character varying, double precision)    FUNCTION     ?   CREATE FUNCTION public.update_xe(_bien_so character varying, _gia_thue double precision) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	
		
		update xe
		set gia_thue=_gia_thue
		where bien_so=_bien_so;
		return 200;
	
	
end
$$;
 X   DROP FUNCTION public.update_xe(_bien_so character varying, _gia_thue double precision);
       public          postgres    false            4           0    0 J   FUNCTION update_xe(_bien_so character varying, _gia_thue double precision)    ACL     h   GRANT ALL ON FUNCTION public.update_xe(_bien_so character varying, _gia_thue double precision) TO boss;
          public          postgres    false    215            ?            1255    16517 7   update_xe(character varying, double precision, boolean)    FUNCTION     )  CREATE FUNCTION public.update_xe(_bien_so character varying, _gia_thue double precision, _status boolean) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	
		
		update xe
		set gia_thue=_gia_thue,status=_status
		where bien_so=_bien_so;
		--PERFORM pg_sleep(10);
		
		return 200;
	
	
end
$$;
 i   DROP FUNCTION public.update_xe(_bien_so character varying, _gia_thue double precision, _status boolean);
       public          postgres    false            5           0    0 [   FUNCTION update_xe(_bien_so character varying, _gia_thue double precision, _status boolean)    ACL     y   GRANT ALL ON FUNCTION public.update_xe(_bien_so character varying, _gia_thue double precision, _status boolean) TO boss;
          public          postgres    false    233            ?            1259    57593    bao_hanh_stt_seq    SEQUENCE     ?   ALTER TABLE public.bao_hanh ALTER COLUMN stt ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.bao_hanh_stt_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    211            ?            1259    16473    ct_hop_dong    TABLE     (  CREATE TABLE public.ct_hop_dong (
    bien_so_hd character varying(15) NOT NULL,
    gia_thue double precision,
    so_ngay_thue integer,
    tong_tien double precision,
    ngay_tra date,
    km_hien_tai integer,
    status boolean,
    km_tra integer,
    id_hop_dong character(30) NOT NULL
);
    DROP TABLE public.ct_hop_dong;
       public         heap    postgres    false            6           0    0    TABLE ct_hop_dong    ACL     ?   GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.ct_hop_dong TO boss;
GRANT SELECT,INSERT ON TABLE public.ct_hop_dong TO employee;
          public          postgres    false    205            ?            1259    16407    hang_xe    TABLE     b   CREATE TABLE public.hang_xe (
    id_hang integer NOT NULL,
    ten_hang character varying(20)
);
    DROP TABLE public.hang_xe;
       public         heap    postgres    false            7           0    0    TABLE hang_xe    ACL     |   GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.hang_xe TO boss;
GRANT SELECT,INSERT ON TABLE public.hang_xe TO employee;
          public          postgres    false    201            ?            1259    16405    hang_xe_id_hang_seq    SEQUENCE     ?   ALTER TABLE public.hang_xe ALTER COLUMN id_hang ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.hang_xe_id_hang_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    201            ?            1259    49339    hop_dong_stt_seq    SEQUENCE     ?   ALTER TABLE public.hop_dong ALTER COLUMN stt ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.hop_dong_stt_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    204            ?            1259    57641 	   phan_cong    TABLE     ?   CREATE TABLE public.phan_cong (
    tai_xe character(13) NOT NULL,
    bien_so_hd character(15) NOT NULL,
    id_hop_dong character(30) NOT NULL,
    from_date date,
    to_date date
);
    DROP TABLE public.phan_cong;
       public         heap    postgres    false            ?            1259    16493    phieu_phat_id_phieu_phat_seq    SEQUENCE     ?   ALTER TABLE public.phieu_phat ALTER COLUMN id_phieu_phat ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.phieu_phat_id_phieu_phat_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    207            ?            1259    57636    taixe    TABLE     ?   CREATE TABLE public.taixe (
    cmnd character(13) NOT NULL,
    ten_tx character(40),
    ngay_sinh date,
    status boolean
);
    DROP TABLE public.taixe;
       public         heap    postgres    false                      0    57595    bao_hanh 
   TABLE DATA           7   COPY public.bao_hanh (stt, id_phieu, ngay) FROM stdin;
    public          postgres    false    211   i?                 0    16473    ct_hop_dong 
   TABLE DATA           ?   COPY public.ct_hop_dong (bien_so_hd, gia_thue, so_ngay_thue, tong_tien, ngay_tra, km_hien_tai, status, km_tra, id_hop_dong) FROM stdin;
    public          postgres    false    205   Ϊ                 0    57600    ct_phieu_bao_hanh 
   TABLE DATA           P   COPY public.ct_phieu_bao_hanh (id_phieu, bien_so, chi_phi, ghi_chu) FROM stdin;
    public          postgres    false    212   R?                 0    16407    hang_xe 
   TABLE DATA           4   COPY public.hang_xe (id_hang, ten_hang) FROM stdin;
    public          postgres    false    201   /?                 0    49384    hoa_don 
   TABLE DATA           T   COPY public.hoa_don (id_hop_dong, bien_so_hd, id_phieu_phat, tong_tien) FROM stdin;
    public          postgres    false    209   d?                 0    16453    hop_dong 
   TABLE DATA           X   COPY public.hop_dong (ngay_thue, cmnd, tien_coc, id_hop_dong, stt, tra_coc) FROM stdin;
    public          postgres    false    204   d?                 0    16422    khach 
   TABLE DATA           H   COPY public.khach (cmnd, ten, dia_chi, sdt, ngay_sinh, anh) FROM stdin;
    public          postgres    false    203   ??                 0    57641 	   phan_cong 
   TABLE DATA           X   COPY public.phan_cong (tai_xe, bien_so_hd, id_hop_dong, from_date, to_date) FROM stdin;
    public          postgres    false    214   ??                 0    16495 
   phieu_phat 
   TABLE DATA           q   COPY public.phieu_phat (id_phieu_phat, id_hop_dong, so_ngay_tre, tong_tien_phat, km_tre, bien_so_hd) FROM stdin;
    public          postgres    false    207   	?                 0    57636    taixe 
   TABLE DATA           @   COPY public.taixe (cmnd, ten_tx, ngay_sinh, status) FROM stdin;
    public          postgres    false    213   ??                 0    16412    xe 
   TABLE DATA           V   COPY public.xe (bien_so, id_hang, ten_xe, gia_thue, ma_kiem_soat, status) FROM stdin;
    public          postgres    false    202   B?       8           0    0    bao_hanh_stt_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.bao_hanh_stt_seq', 7, true);
          public          postgres    false    210            9           0    0    hang_xe_id_hang_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.hang_xe_id_hang_seq', 3, true);
          public          postgres    false    200            :           0    0    hop_dong_stt_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.hop_dong_stt_seq', 75, true);
          public          postgres    false    208            ;           0    0    phieu_phat_id_phieu_phat_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public.phieu_phat_id_phieu_phat_seq', 28, true);
          public          postgres    false    206            w           2606    57599    bao_hanh bao_hanh_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.bao_hanh
    ADD CONSTRAINT bao_hanh_pkey PRIMARY KEY (id_phieu);
 @   ALTER TABLE ONLY public.bao_hanh DROP CONSTRAINT bao_hanh_pkey;
       public            postgres    false    211            q           2606    49333    ct_hop_dong ct_hop_dong_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public.ct_hop_dong
    ADD CONSTRAINT ct_hop_dong_pkey PRIMARY KEY (id_hop_dong, bien_so_hd);
 F   ALTER TABLE ONLY public.ct_hop_dong DROP CONSTRAINT ct_hop_dong_pkey;
       public            postgres    false    205    205            y           2606    57607 (   ct_phieu_bao_hanh ct_phieu_bao_hanh_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public.ct_phieu_bao_hanh
    ADD CONSTRAINT ct_phieu_bao_hanh_pkey PRIMARY KEY (id_phieu);
 R   ALTER TABLE ONLY public.ct_phieu_bao_hanh DROP CONSTRAINT ct_phieu_bao_hanh_pkey;
       public            postgres    false    212            i           2606    16411    hang_xe hang_xe_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.hang_xe
    ADD CONSTRAINT hang_xe_pkey PRIMARY KEY (id_hang);
 >   ALTER TABLE ONLY public.hang_xe DROP CONSTRAINT hang_xe_pkey;
       public            postgres    false    201            u           2606    49388    hoa_don hoa_don_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public.hoa_don
    ADD CONSTRAINT hoa_don_pkey PRIMARY KEY (id_hop_dong, bien_so_hd);
 >   ALTER TABLE ONLY public.hoa_don DROP CONSTRAINT hoa_don_pkey;
       public            postgres    false    209    209            o           2606    49335    hop_dong hop_dong_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.hop_dong
    ADD CONSTRAINT hop_dong_pkey PRIMARY KEY (id_hop_dong);
 @   ALTER TABLE ONLY public.hop_dong DROP CONSTRAINT hop_dong_pkey;
       public            postgres    false    204            m           2606    16426    khach khach_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.khach
    ADD CONSTRAINT khach_pkey PRIMARY KEY (cmnd);
 :   ALTER TABLE ONLY public.khach DROP CONSTRAINT khach_pkey;
       public            postgres    false    203            }           2606    57645    phan_cong phan_cong_pkey 
   CONSTRAINT     s   ALTER TABLE ONLY public.phan_cong
    ADD CONSTRAINT phan_cong_pkey PRIMARY KEY (tai_xe, bien_so_hd, id_hop_dong);
 B   ALTER TABLE ONLY public.phan_cong DROP CONSTRAINT phan_cong_pkey;
       public            postgres    false    214    214    214            s           2606    16504    phieu_phat phieu_phat_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.phieu_phat
    ADD CONSTRAINT phieu_phat_pkey PRIMARY KEY (id_phieu_phat);
 D   ALTER TABLE ONLY public.phieu_phat DROP CONSTRAINT phieu_phat_pkey;
       public            postgres    false    207            {           2606    57640    taixe taixe_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.taixe
    ADD CONSTRAINT taixe_pkey PRIMARY KEY (cmnd);
 :   ALTER TABLE ONLY public.taixe DROP CONSTRAINT taixe_pkey;
       public            postgres    false    213            k           2606    16416 
   xe xe_pkey 
   CONSTRAINT     M   ALTER TABLE ONLY public.xe
    ADD CONSTRAINT xe_pkey PRIMARY KEY (bien_so);
 4   ALTER TABLE ONLY public.xe DROP CONSTRAINT xe_pkey;
       public            postgres    false    202            ?           2606    16483 '   ct_hop_dong ct_hop_dong_bien_so_hd_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public.ct_hop_dong
    ADD CONSTRAINT ct_hop_dong_bien_so_hd_fkey FOREIGN KEY (bien_so_hd) REFERENCES public.xe(bien_so);
 Q   ALTER TABLE ONLY public.ct_hop_dong DROP CONSTRAINT ct_hop_dong_bien_so_hd_fkey;
       public          postgres    false    202    205    2923            ?           2606    57613    ct_phieu_bao_hanh fk_bien_so    FK CONSTRAINT     }   ALTER TABLE ONLY public.ct_phieu_bao_hanh
    ADD CONSTRAINT fk_bien_so FOREIGN KEY (bien_so) REFERENCES public.xe(bien_so);
 F   ALTER TABLE ONLY public.ct_phieu_bao_hanh DROP CONSTRAINT fk_bien_so;
       public          postgres    false    202    212    2923                       2606    49369    hop_dong fk_cmnd    FK CONSTRAINT     n   ALTER TABLE ONLY public.hop_dong
    ADD CONSTRAINT fk_cmnd FOREIGN KEY (cmnd) REFERENCES public.khach(cmnd);
 :   ALTER TABLE ONLY public.hop_dong DROP CONSTRAINT fk_cmnd;
       public          postgres    false    203    204    2925            ?           2606    49389    hoa_don fk_hoadon_hd    FK CONSTRAINT     ?   ALTER TABLE ONLY public.hoa_don
    ADD CONSTRAINT fk_hoadon_hd FOREIGN KEY (id_hop_dong, bien_so_hd) REFERENCES public.ct_hop_dong(id_hop_dong, bien_so_hd);
 >   ALTER TABLE ONLY public.hoa_don DROP CONSTRAINT fk_hoadon_hd;
       public          postgres    false    205    2929    209    209    205            ?           2606    49394    hoa_don fk_hoadon_pp    FK CONSTRAINT     ?   ALTER TABLE ONLY public.hoa_don
    ADD CONSTRAINT fk_hoadon_pp FOREIGN KEY (id_phieu_phat) REFERENCES public.phieu_phat(id_phieu_phat);
 >   ALTER TABLE ONLY public.hoa_don DROP CONSTRAINT fk_hoadon_pp;
       public          postgres    false    207    209    2931            ?           2606    57665    phan_cong fk_hopdong    FK CONSTRAINT     ?   ALTER TABLE ONLY public.phan_cong
    ADD CONSTRAINT fk_hopdong FOREIGN KEY (bien_so_hd, id_hop_dong) REFERENCES public.ct_hop_dong(bien_so_hd, id_hop_dong);
 >   ALTER TABLE ONLY public.phan_cong DROP CONSTRAINT fk_hopdong;
       public          postgres    false    2929    214    205    214    205            ?           2606    49364    ct_hop_dong fk_id_hop_dong    FK CONSTRAINT     ?   ALTER TABLE ONLY public.ct_hop_dong
    ADD CONSTRAINT fk_id_hop_dong FOREIGN KEY (id_hop_dong) REFERENCES public.hop_dong(id_hop_dong);
 D   ALTER TABLE ONLY public.ct_hop_dong DROP CONSTRAINT fk_id_hop_dong;
       public          postgres    false    204    205    2927            ?           2606    57608    ct_phieu_bao_hanh fk_phieu    FK CONSTRAINT     ?   ALTER TABLE ONLY public.ct_phieu_bao_hanh
    ADD CONSTRAINT fk_phieu FOREIGN KEY (id_phieu) REFERENCES public.bao_hanh(id_phieu);
 D   ALTER TABLE ONLY public.ct_phieu_bao_hanh DROP CONSTRAINT fk_phieu;
       public          postgres    false    211    212    2935            ?           2606    49379    phieu_phat fk_phieu_phat    FK CONSTRAINT     ?   ALTER TABLE ONLY public.phieu_phat
    ADD CONSTRAINT fk_phieu_phat FOREIGN KEY (id_hop_dong, bien_so_hd) REFERENCES public.ct_hop_dong(id_hop_dong, bien_so_hd);
 B   ALTER TABLE ONLY public.phieu_phat DROP CONSTRAINT fk_phieu_phat;
       public          postgres    false    205    207    207    205    2929            ?           2606    57646    phan_cong fk_taixe    FK CONSTRAINT     r   ALTER TABLE ONLY public.phan_cong
    ADD CONSTRAINT fk_taixe FOREIGN KEY (tai_xe) REFERENCES public.taixe(cmnd);
 <   ALTER TABLE ONLY public.phan_cong DROP CONSTRAINT fk_taixe;
       public          postgres    false    2939    214    213            ~           2606    16417    xe xe_id_hang_fkey    FK CONSTRAINT     x   ALTER TABLE ONLY public.xe
    ADD CONSTRAINT xe_id_hang_fkey FOREIGN KEY (id_hang) REFERENCES public.hang_xe(id_hang);
 <   ALTER TABLE ONLY public.xe DROP CONSTRAINT xe_id_hang_fkey;
       public          postgres    false    2921    201    202               U   x?]?1
?0F???)?@?I??2.?N.??H3(????1?gn$??&??q?C>?5???$6???5xCso?????n????^=$#k         t  x????m?0D??)???(R?g;G???d??l??d7m?$t???;J??YT?????~??	3i ??{-????$????Ҿ&1??$????h??????J)${>%Q???˅G????=?????S?(_?R????!??????y):?Kӯކ<??146?{?F*?6Dȿ?:?K?{??!6v^y?t
k?^ ?c?	?s?$?$es$n?ć?qĻNt?k??}??K?	L???D?????????G~ඨ???ԋ???<+??UM?e???~ἲql{w_k?p??˝#Wh7???1޺????|???T??Sa?#???c/Og??TEw*<??v??`
?????~???/?ô9?z? j?????????i?~ ?~%r         ?   x??ֱ?0@??7?- J??%,?4??p? b
j&?D4H?,@J&?&??)?&E?+?W<??gF??#"??H?T?H?XD>6/04? !?2?Y???'U`1? %/	?mA*"6s?k??q)Z??Xלm?c?:??߆]???I,$?`!?,j??4f?U?뤡NE0~N?.?"w?a?v??"?z)?^?u,? ??b??         %   x?3?,ɯ?/I?2????KI?2?L?/J?????? ???         ?   x????q?0?Pi??O?\??>??
ƲM?H?????,?A?jF(j_7ҏ???'$#Y^k-q&"??a?6??S|~?X?WT?"????j=??Nnv?(?sb" S????6V??r*	8 ????-???F??{d(???+e???^?
̳?JK?5?H?*???}?|Ve???????Rph???K?/U?F?O!?P???e?x????]?????t?Mj?/??9M?7?ҳ?         /  x???A??0E??sF????.?D#0??8U??-
??????0g???/1W]??*????W?m????JT???w ??@9?5?o$,???$????k??Aؗ??$?U?L?j??XrBB?Oq?Aڳ?~?????}???1???S?
?1H$܀?D??? ??$???پ?????@?@?Hܯ2?_A&-C?A%?Ur3A?H ?T???PpIm? .???rr
?????rR??K??? ?	??=\j?m?rM ??#?o{?x3o&j8K???????5'??i?? ?         ?   x?5?1n?0Eg???R}Jb??m?LF? S?(l??r?R?$}>?/?t?$Э?e)w>oe???I?????|+??K#?5X^#3r??p"?A??a??S???l??#Os{?T?l|?]?B~?Q$k??ｃ???QĤ???W?y??iY	??R???jFb?
?'???^F?c??v?u?(??=??????JGKj<kk?u??0???F?         v   x???M?@??s
/@3?	?,?9\ڤ???#6??1??/P/??>???Yj??I??`??=??j?	?e)????(?ۋ?t????9ߑ?{??w?#??q????c?tJ)-?9?         ?   x???K? D???@*lc??9?????Aͧi"?	?cf ?QT	???Ir?`J ?-G \
X?-HJ?	?@?\	???C"`??m?p_?x?A ?A???J??`????{0G|t?? ????p??Nc`??cx.?ŭ򴭒i?PF	%v???	dہ?h?|m?????????~_g????W?՛?70?	yG?#???z\Co?HnX         H   x?3424R?N???ʇ?[?<J+?N###]c]C?4?????TJb^:~?p3t??hF? ?W?         ?   x?]??N!???S?`:? {ܚ4=7????k%?Ұk???P$?????ט~?	?X??	??>v?*??X??????B??m8\??W?$???đ?"??Iz??? ?)????G?o ??N?.??5*R?8??q? ??YRi??"?gE?o?!????*?RR?Phc?(_??2?"K???c???)?<?-??{? ??"?rx?P?z?>,????$-?????4mes>?}BZ?4?????We{?????#?o?     