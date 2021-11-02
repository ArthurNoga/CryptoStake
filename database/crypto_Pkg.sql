create package pkg_mange_cryp as
    -- todo: implement
    procedure add_updateCrypto(p_id varchar2, p_name varchar2, p_achat float, p_vente float, p_evol float);
end pkg_mange_cryp;
/

create package body pkg_mange_cryp as
    -- todo: implement
    procedure add_updateCrypto(p_id varchar2, p_name varchar2, p_achat float, p_vente float, p_evol float) is
        v_id varchar2(32);
    begin
        select CRYPT_ID into v_id from CRYPTO where CRYPT_ID = p_id;
        if v_id is not null then
            update CRYPTO set CRYPT_ACHAT = p_achat, CRYPT_VENTE=p_vente, CRYPT_EVOL=p_evol where CRYPT_ID = p_id;


        end if;
    exception
        when no_data_found then
            insert into CRYPTO (CRYPT_ID, CRYPT_NOM, CRYPT_ACHAT, CRYPT_VENTE, CRYPT_EVOL)
            values (p_id, p_name, p_achat, p_vente, p_evol);

    end;
end pkg_mange_cryp;
/


