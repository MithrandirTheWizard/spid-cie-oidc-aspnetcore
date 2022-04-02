﻿using Microsoft.Extensions.Logging;
using Moq;
using Spid.Cie.OIDC.AspNetCore.Services;
using Xunit;

namespace Spid.Cie.OIDC.AspNetCore.Tests;

public class MetadataPolicyHandlerTests
{
    [Fact]
    public async void MetadataPolicyWithAdd()
    {
        var handler = new MetadataPolicyHandler(Mock.Of<ILogger<MetadataPolicyHandler>>());
        var decodedOP = "{\"exp\":1648027027,\"iat\":1647854227,\"iss\":\"http://127.0.0.1:8000/oidc/op/\",\"sub\":\"http://127.0.0.1:8000/oidc/op/\",\"jwks\":{\"keys\":[{\"kty\":\"RSA\",\"n\":\"01_4aI2Lu5ggsElmRkE_S_a83V_szXU0txV4db2hmJ8HR1Y2s7PsZZ5-emGpnTydGrR3n-QExeEEIcFt_a06Ryiink34RQcKoGXUDBMBU0Bu8G7NcZ99YX6yeG9wFi4xs-WviTPmtPqijkz6jm1_ltWDcwbktfkraIRKKggZaEl9ldtsFr2wSpin3AXuGIdeJ0hZqhF92ODBLGjJlaIL9KlwopDy56adReVnraawSdrxmuPGj78IEADNAme2nQNvv9UCu0FkAn5St1bKds3Gpv26W0kjr1gZLsmQrj9lTcDk_KbAwfEY__P7se62kusoSuKMTQqUG1TQpUY7oFGSdw\",\"e\":\"AQAB\",\"kid\":\"dB67gL7ck3TFiIAf7N6_7SHvqk0MDYMEQcoGGlkUAAw\"}]},\"metadata\":{\"openid_provider\":{\"authorization_endpoint\":\"http://127.0.0.1:8000/oidc/op/authorization\",\"revocation_endpoint\":\"http://127.0.0.1:8000/oidc/op/revocation/\",\"id_token_encryption_alg_values_supported\":[\"RSA-OAEP\"],\"id_token_encryption_enc_values_supported\":[\"A128CBC-HS256\"],\"op_name\":\"Agenzia per l’Italia Digitale\",\"op_uri\":\"https://www.agid.gov.it\",\"token_endpoint\":\"http://127.0.0.1:8000/oidc/op/token/\",\"userinfo_endpoint\":\"http://127.0.0.1:8000/oidc/op/userinfo/\",\"introspection_endpoint\":\"http://127.0.0.1:8000/oidc/op/introspection/\",\"claims_parameter_supported\":true,\"contacts\":[\"ops@https://idp.it\"],\"client_registration_types_supported\":[\"automatic\"],\"code_challenge_methods_supported\":[\"S256\"],\"request_authentication_methods_supported\":{\"ar\":[\"request_object\"]},\"acr_values_supported\":[\"https://www.spid.gov.it/SpidL1\",\"https://www.spid.gov.it/SpidL2\",\"https://www.spid.gov.it/SpidL3\"],\"claims_supported\":[\"https://attributes.spid.gov.it/spidCode\",\"https://attributes.spid.gov.it/name\",\"https://attributes.spid.gov.it/familyName\",\"https://attributes.spid.gov.it/placeOfBirth\",\"https://attributes.spid.gov.it/countyOfBirth\",\"https://attributes.spid.gov.it/dateOfBirth\",\"https://attributes.spid.gov.it/gender\",\"https://attributes.spid.gov.it/companyName\",\"https://attributes.spid.gov.it/registeredOffice\",\"https://attributes.spid.gov.it/fiscalNumber\",\"https://attributes.spid.gov.it/ivaCode\",\"https://attributes.spid.gov.it/idCard\",\"https://attributes.spid.gov.it/mobilePhone\",\"https://attributes.spid.gov.it/email\",\"https://attributes.spid.gov.it/address\",\"https://attributes.spid.gov.it/expirationDate\",\"https://attributes.spid.gov.it/digitalAddress\"],\"grant_types_supported\":[\"authorization_code\",\"refresh_token\"],\"id_token_signing_alg_values_supported\":[\"RS256\",\"ES256\"],\"issuer\":\"http://127.0.0.1:8000/oidc/op/\",\"jwks\":{\"keys\":[{\"kty\":\"RSA\",\"use\":\"sig\",\"n\":\"01_4aI2Lu5ggsElmRkE_S_a83V_szXU0txV4db2hmJ8HR1Y2s7PsZZ5-emGpnTydGrR3n-QExeEEIcFt_a06Ryiink34RQcKoGXUDBMBU0Bu8G7NcZ99YX6yeG9wFi4xs-WviTPmtPqijkz6jm1_ltWDcwbktfkraIRKKggZaEl9ldtsFr2wSpin3AXuGIdeJ0hZqhF92ODBLGjJlaIL9KlwopDy56adReVnraawSdrxmuPGj78IEADNAme2nQNvv9UCu0FkAn5St1bKds3Gpv26W0kjr1gZLsmQrj9lTcDk_KbAwfEY__P7se62kusoSuKMTQqUG1TQpUY7oFGSdw\",\"e\":\"AQAB\",\"kid\":\"dB67gL7ck3TFiIAf7N6_7SHvqk0MDYMEQcoGGlkUAAw\"}]},\"scopes_supported\":[\"openid\",\"offline_access\"],\"logo_uri\":\"http://127.0.0.1:8000/static/svg/spid-logo-c-lb.svg\",\"organization_name\":\"SPID OIDC identity provider\",\"op_policy_uri\":\"http://127.0.0.1:8000/oidc/op/en/website/legal-information/\",\"request_parameter_supported\":true,\"request_uri_parameter_supported\":true,\"require_request_uri_registration\":true,\"response_types_supported\":[\"code\"],\"subject_types_supported\":[\"pairwise\",\"public\"],\"token_endpoint_auth_methods_supported\":[\"private_key_jwt\"],\"token_endpoint_auth_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"],\"userinfo_encryption_alg_values_supported\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"],\"userinfo_encryption_enc_values_supported\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"],\"userinfo_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"],\"request_object_encryption_alg_values_supported\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"],\"request_object_encryption_enc_values_supported\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"],\"request_object_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]}},\"authority_hints\":[\"http://127.0.0.1:8000/\"]}";
        var metadataPolicy = "{\"contacts\":{\"add\":[\"info@rp.test\"]},\"subject_types_supported\":{\"value\":[\"pairwise\"]},\"id_token_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]},\"userinfo_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]},\"token_endpoint_auth_methods_supported\":{\"value\":[\"private_key_jwt\"]},\"userinfo_encryption_alg_values_supported\":{\"subset_of\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"]},\"userinfo_encryption_enc_values_supported\":{\"subset_of\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"]},\"request_object_encryption_alg_values_supported\":{\"subset_of\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"]},\"request_object_encryption_enc_values_supported\":{\"subset_of\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"]},\"request_object_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]}}";
        var result = handler.ApplyMetadataPolicy(decodedOP, metadataPolicy);
    }

    [Fact]
    public async void MetadataPolicyWithDefault()
    {
        var handler = new MetadataPolicyHandler(Mock.Of<ILogger<MetadataPolicyHandler>>());
        var decodedOP = "{\"exp\":1648027027,\"iat\":1647854227,\"iss\":\"http://127.0.0.1:8000/oidc/op/\",\"sub\":\"http://127.0.0.1:8000/oidc/op/\",\"jwks\":{\"keys\":[{\"kty\":\"RSA\",\"n\":\"01_4aI2Lu5ggsElmRkE_S_a83V_szXU0txV4db2hmJ8HR1Y2s7PsZZ5-emGpnTydGrR3n-QExeEEIcFt_a06Ryiink34RQcKoGXUDBMBU0Bu8G7NcZ99YX6yeG9wFi4xs-WviTPmtPqijkz6jm1_ltWDcwbktfkraIRKKggZaEl9ldtsFr2wSpin3AXuGIdeJ0hZqhF92ODBLGjJlaIL9KlwopDy56adReVnraawSdrxmuPGj78IEADNAme2nQNvv9UCu0FkAn5St1bKds3Gpv26W0kjr1gZLsmQrj9lTcDk_KbAwfEY__P7se62kusoSuKMTQqUG1TQpUY7oFGSdw\",\"e\":\"AQAB\",\"kid\":\"dB67gL7ck3TFiIAf7N6_7SHvqk0MDYMEQcoGGlkUAAw\"}]},\"metadata\":{\"openid_provider\":{\"authorization_endpoint\":\"http://127.0.0.1:8000/oidc/op/authorization\",\"revocation_endpoint\":\"http://127.0.0.1:8000/oidc/op/revocation/\",\"id_token_encryption_alg_values_supported\":[\"RSA-OAEP\"],\"id_token_encryption_enc_values_supported\":[\"A128CBC-HS256\"],\"op_name\":\"Agenzia per l’Italia Digitale\",\"op_uri\":\"https://www.agid.gov.it\",\"token_endpoint\":\"http://127.0.0.1:8000/oidc/op/token/\",\"userinfo_endpoint\":\"http://127.0.0.1:8000/oidc/op/userinfo/\",\"introspection_endpoint\":\"http://127.0.0.1:8000/oidc/op/introspection/\",\"claims_parameter_supported\":true,\"contacts\":[],\"client_registration_types_supported\":[\"automatic\"],\"code_challenge_methods_supported\":[\"S256\"],\"request_authentication_methods_supported\":{\"ar\":[\"request_object\"]},\"acr_values_supported\":[\"https://www.spid.gov.it/SpidL1\",\"https://www.spid.gov.it/SpidL2\",\"https://www.spid.gov.it/SpidL3\"],\"claims_supported\":[\"https://attributes.spid.gov.it/spidCode\",\"https://attributes.spid.gov.it/name\",\"https://attributes.spid.gov.it/familyName\",\"https://attributes.spid.gov.it/placeOfBirth\",\"https://attributes.spid.gov.it/countyOfBirth\",\"https://attributes.spid.gov.it/dateOfBirth\",\"https://attributes.spid.gov.it/gender\",\"https://attributes.spid.gov.it/companyName\",\"https://attributes.spid.gov.it/registeredOffice\",\"https://attributes.spid.gov.it/fiscalNumber\",\"https://attributes.spid.gov.it/ivaCode\",\"https://attributes.spid.gov.it/idCard\",\"https://attributes.spid.gov.it/mobilePhone\",\"https://attributes.spid.gov.it/email\",\"https://attributes.spid.gov.it/address\",\"https://attributes.spid.gov.it/expirationDate\",\"https://attributes.spid.gov.it/digitalAddress\"],\"grant_types_supported\":[\"authorization_code\",\"refresh_token\"],\"id_token_signing_alg_values_supported\":[\"RS256\",\"ES256\"],\"issuer\":\"http://127.0.0.1:8000/oidc/op/\",\"jwks\":{\"keys\":[{\"kty\":\"RSA\",\"use\":\"sig\",\"n\":\"01_4aI2Lu5ggsElmRkE_S_a83V_szXU0txV4db2hmJ8HR1Y2s7PsZZ5-emGpnTydGrR3n-QExeEEIcFt_a06Ryiink34RQcKoGXUDBMBU0Bu8G7NcZ99YX6yeG9wFi4xs-WviTPmtPqijkz6jm1_ltWDcwbktfkraIRKKggZaEl9ldtsFr2wSpin3AXuGIdeJ0hZqhF92ODBLGjJlaIL9KlwopDy56adReVnraawSdrxmuPGj78IEADNAme2nQNvv9UCu0FkAn5St1bKds3Gpv26W0kjr1gZLsmQrj9lTcDk_KbAwfEY__P7se62kusoSuKMTQqUG1TQpUY7oFGSdw\",\"e\":\"AQAB\",\"kid\":\"dB67gL7ck3TFiIAf7N6_7SHvqk0MDYMEQcoGGlkUAAw\"}]},\"scopes_supported\":[\"openid\",\"offline_access\"],\"logo_uri\":\"http://127.0.0.1:8000/static/svg/spid-logo-c-lb.svg\",\"organization_name\":\"SPID OIDC identity provider\",\"op_policy_uri\":\"http://127.0.0.1:8000/oidc/op/en/website/legal-information/\",\"request_parameter_supported\":true,\"request_uri_parameter_supported\":true,\"require_request_uri_registration\":true,\"response_types_supported\":[\"code\"],\"subject_types_supported\":[\"pairwise\",\"public\"],\"token_endpoint_auth_methods_supported\":[\"private_key_jwt\"],\"token_endpoint_auth_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"],\"userinfo_encryption_alg_values_supported\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"],\"userinfo_encryption_enc_values_supported\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"],\"userinfo_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"],\"request_object_encryption_alg_values_supported\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"],\"request_object_encryption_enc_values_supported\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"],\"request_object_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]}},\"authority_hints\":[\"http://127.0.0.1:8000/\"]}";
        var metadataPolicy = "{\"contacts\":{\"default\":[\"info@rp.test\"]},\"subject_types_supported\":{\"value\":[\"pairwise\"]},\"id_token_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]},\"userinfo_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]},\"token_endpoint_auth_methods_supported\":{\"value\":[\"private_key_jwt\"]},\"userinfo_encryption_alg_values_supported\":{\"subset_of\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"]},\"userinfo_encryption_enc_values_supported\":{\"subset_of\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"]},\"request_object_encryption_alg_values_supported\":{\"subset_of\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"]},\"request_object_encryption_enc_values_supported\":{\"subset_of\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"]},\"request_object_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]}}";
        var result = handler.ApplyMetadataPolicy(decodedOP, metadataPolicy);
    }

    [Fact]
    public async void MetadataPolicyWithError()
    {
        var handler = new MetadataPolicyHandler(Mock.Of<ILogger<MetadataPolicyHandler>>());
        var decodedOP = "{\"exp\":1648027027,\"iat\":1647854227,\"iss\":\"http://127.0.0.1:8000/oidc/op/\",\"sub\":\"http://127.0.0.1:8000/oidc/op/\",\"jwks\":{\"keys\":[{\"kty\":\"RSA\",\"n\":\"01_4aI2Lu5ggsElmRkE_S_a83V_szXU0txV4db2hmJ8HR1Y2s7PsZZ5-emGpnTydGrR3n-QExeEEIcFt_a06Ryiink34RQcKoGXUDBMBU0Bu8G7NcZ99YX6yeG9wFi4xs-WviTPmtPqijkz6jm1_ltWDcwbktfkraIRKKggZaEl9ldtsFr2wSpin3AXuGIdeJ0hZqhF92ODBLGjJlaIL9KlwopDy56adReVnraawSdrxmuPGj78IEADNAme2nQNvv9UCu0FkAn5St1bKds3Gpv26W0kjr1gZLsmQrj9lTcDk_KbAwfEY__P7se62kusoSuKMTQqUG1TQpUY7oFGSdw\",\"e\":\"AQAB\",\"kid\":\"dB67gL7ck3TFiIAf7N6_7SHvqk0MDYMEQcoGGlkUAAw\"}]},\"metadata\":{\"openid_provider\":{\"authorization_endpoint\":\"http://127.0.0.1:8000/oidc/op/authorization\",\"revocation_endpoint\":\"http://127.0.0.1:8000/oidc/op/revocation/\",\"id_token_encryption_alg_values_supported\":[\"RSA-OAEP\"],\"id_token_encryption_enc_values_supported\":[\"A128CBC-HS256\"],\"op_name\":\"Agenzia per l’Italia Digitale\",\"op_uri\":\"https://www.agid.gov.it\",\"token_endpoint\":\"http://127.0.0.1:8000/oidc/op/token/\",\"userinfo_endpoint\":\"http://127.0.0.1:8000/oidc/op/userinfo/\",\"introspection_endpoint\":\"http://127.0.0.1:8000/oidc/op/introspection/\",\"claims_parameter_supported\":true,\"contacts\":[],\"client_registration_types_supported\":[\"automatic\"],\"code_challenge_methods_supported\":[\"S256\"],\"request_authentication_methods_supported\":{\"ar\":[\"request_object\"]},\"acr_values_supported\":[\"https://www.spid.gov.it/SpidL1\",\"https://www.spid.gov.it/SpidL2\",\"https://www.spid.gov.it/SpidL3\"],\"claims_supported\":[\"https://attributes.spid.gov.it/spidCode\",\"https://attributes.spid.gov.it/name\",\"https://attributes.spid.gov.it/familyName\",\"https://attributes.spid.gov.it/placeOfBirth\",\"https://attributes.spid.gov.it/countyOfBirth\",\"https://attributes.spid.gov.it/dateOfBirth\",\"https://attributes.spid.gov.it/gender\",\"https://attributes.spid.gov.it/companyName\",\"https://attributes.spid.gov.it/registeredOffice\",\"https://attributes.spid.gov.it/fiscalNumber\",\"https://attributes.spid.gov.it/ivaCode\",\"https://attributes.spid.gov.it/idCard\",\"https://attributes.spid.gov.it/mobilePhone\",\"https://attributes.spid.gov.it/email\",\"https://attributes.spid.gov.it/address\",\"https://attributes.spid.gov.it/expirationDate\",\"https://attributes.spid.gov.it/digitalAddress\"],\"grant_types_supported\":[\"authorization_code\",\"refresh_token\"],\"id_token_signing_alg_values_supported\":[\"RS256\",\"ES256\"],\"issuer\":\"http://127.0.0.1:8000/oidc/op/\",\"jwks\":{\"keys\":[{\"kty\":\"RSA\",\"use\":\"sig\",\"n\":\"01_4aI2Lu5ggsElmRkE_S_a83V_szXU0txV4db2hmJ8HR1Y2s7PsZZ5-emGpnTydGrR3n-QExeEEIcFt_a06Ryiink34RQcKoGXUDBMBU0Bu8G7NcZ99YX6yeG9wFi4xs-WviTPmtPqijkz6jm1_ltWDcwbktfkraIRKKggZaEl9ldtsFr2wSpin3AXuGIdeJ0hZqhF92ODBLGjJlaIL9KlwopDy56adReVnraawSdrxmuPGj78IEADNAme2nQNvv9UCu0FkAn5St1bKds3Gpv26W0kjr1gZLsmQrj9lTcDk_KbAwfEY__P7se62kusoSuKMTQqUG1TQpUY7oFGSdw\",\"e\":\"AQAB\",\"kid\":\"dB67gL7ck3TFiIAf7N6_7SHvqk0MDYMEQcoGGlkUAAw\"}]},\"scopes_supported\":[\"openid\",\"offline_access\"],\"logo_uri\":\"http://127.0.0.1:8000/static/svg/spid-logo-c-lb.svg\",\"organization_name\":\"SPID OIDC identity provider\",\"op_policy_uri\":\"http://127.0.0.1:8000/oidc/op/en/website/legal-information/\",\"request_parameter_supported\":true,\"request_uri_parameter_supported\":true,\"require_request_uri_registration\":true,\"response_types_supported\":[\"code\"],\"subject_types_supported\":[\"pairwise\",\"public\"],\"token_endpoint_auth_methods_supported\":[\"private_key_jwt\"],\"token_endpoint_auth_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"],\"userinfo_encryption_alg_values_supported\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"],\"userinfo_encryption_enc_values_supported\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"],\"userinfo_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"],\"request_object_encryption_alg_values_supported\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"],\"request_object_encryption_enc_values_supported\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"],\"request_object_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]}},\"authority_hints\":[\"http://127.0.0.1:8000/\"]}";
        var metadataPolicy = "{\"contacts\":{\"essential\":true},\"subject_types_supported\":{\"value\":[\"pairwise\"]},\"id_token_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]},\"userinfo_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]},\"token_endpoint_auth_methods_supported\":{\"value\":[\"private_key_jwt\"]},\"userinfo_encryption_alg_values_supported\":{\"subset_of\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"]},\"userinfo_encryption_enc_values_supported\":{\"subset_of\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"]},\"request_object_encryption_alg_values_supported\":{\"subset_of\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"]},\"request_object_encryption_enc_values_supported\":{\"subset_of\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"]},\"request_object_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]}}";
        Assert.True(handler.ApplyMetadataPolicy(decodedOP, metadataPolicy) == default);
    }

    [Fact]
    public async void MetadataPolicyWithError2()
    {
        var handler = new MetadataPolicyHandler(Mock.Of<ILogger<MetadataPolicyHandler>>());
        var decodedOP = "{\"exp\":1648027027,\"iat\":1647854227,\"iss\":\"http://127.0.0.1:8000/oidc/op/\",\"sub\":\"http://127.0.0.1:8000/oidc/op/\",\"jwks\":{\"keys\":[{\"kty\":\"RSA\",\"n\":\"01_4aI2Lu5ggsElmRkE_S_a83V_szXU0txV4db2hmJ8HR1Y2s7PsZZ5-emGpnTydGrR3n-QExeEEIcFt_a06Ryiink34RQcKoGXUDBMBU0Bu8G7NcZ99YX6yeG9wFi4xs-WviTPmtPqijkz6jm1_ltWDcwbktfkraIRKKggZaEl9ldtsFr2wSpin3AXuGIdeJ0hZqhF92ODBLGjJlaIL9KlwopDy56adReVnraawSdrxmuPGj78IEADNAme2nQNvv9UCu0FkAn5St1bKds3Gpv26W0kjr1gZLsmQrj9lTcDk_KbAwfEY__P7se62kusoSuKMTQqUG1TQpUY7oFGSdw\",\"e\":\"AQAB\",\"kid\":\"dB67gL7ck3TFiIAf7N6_7SHvqk0MDYMEQcoGGlkUAAw\"}]},\"metadata\":{\"openid_provider\":{\"authorization_endpoint\":\"http://127.0.0.1:8000/oidc/op/authorization\",\"revocation_endpoint\":\"http://127.0.0.1:8000/oidc/op/revocation/\",\"id_token_encryption_alg_values_supported\":[\"RSA-OAEP\"],\"id_token_encryption_enc_values_supported\":[\"A128CBC-HS256\"],\"op_name\":\"Agenzia per l’Italia Digitale\",\"op_uri\":\"https://www.agid.gov.it\",\"token_endpoint\":\"http://127.0.0.1:8000/oidc/op/token/\",\"userinfo_endpoint\":\"http://127.0.0.1:8000/oidc/op/userinfo/\",\"introspection_endpoint\":\"http://127.0.0.1:8000/oidc/op/introspection/\",\"claims_parameter_supported\":true,\"client_registration_types_supported\":[\"automatic\"],\"code_challenge_methods_supported\":[\"S256\"],\"request_authentication_methods_supported\":{\"ar\":[\"request_object\"]},\"acr_values_supported\":[\"https://www.spid.gov.it/SpidL1\",\"https://www.spid.gov.it/SpidL2\",\"https://www.spid.gov.it/SpidL3\"],\"claims_supported\":[\"https://attributes.spid.gov.it/spidCode\",\"https://attributes.spid.gov.it/name\",\"https://attributes.spid.gov.it/familyName\",\"https://attributes.spid.gov.it/placeOfBirth\",\"https://attributes.spid.gov.it/countyOfBirth\",\"https://attributes.spid.gov.it/dateOfBirth\",\"https://attributes.spid.gov.it/gender\",\"https://attributes.spid.gov.it/companyName\",\"https://attributes.spid.gov.it/registeredOffice\",\"https://attributes.spid.gov.it/fiscalNumber\",\"https://attributes.spid.gov.it/ivaCode\",\"https://attributes.spid.gov.it/idCard\",\"https://attributes.spid.gov.it/mobilePhone\",\"https://attributes.spid.gov.it/email\",\"https://attributes.spid.gov.it/address\",\"https://attributes.spid.gov.it/expirationDate\",\"https://attributes.spid.gov.it/digitalAddress\"],\"grant_types_supported\":[\"authorization_code\",\"refresh_token\"],\"id_token_signing_alg_values_supported\":[\"RS256\",\"ES256\"],\"issuer\":\"http://127.0.0.1:8000/oidc/op/\",\"jwks\":{\"keys\":[{\"kty\":\"RSA\",\"use\":\"sig\",\"n\":\"01_4aI2Lu5ggsElmRkE_S_a83V_szXU0txV4db2hmJ8HR1Y2s7PsZZ5-emGpnTydGrR3n-QExeEEIcFt_a06Ryiink34RQcKoGXUDBMBU0Bu8G7NcZ99YX6yeG9wFi4xs-WviTPmtPqijkz6jm1_ltWDcwbktfkraIRKKggZaEl9ldtsFr2wSpin3AXuGIdeJ0hZqhF92ODBLGjJlaIL9KlwopDy56adReVnraawSdrxmuPGj78IEADNAme2nQNvv9UCu0FkAn5St1bKds3Gpv26W0kjr1gZLsmQrj9lTcDk_KbAwfEY__P7se62kusoSuKMTQqUG1TQpUY7oFGSdw\",\"e\":\"AQAB\",\"kid\":\"dB67gL7ck3TFiIAf7N6_7SHvqk0MDYMEQcoGGlkUAAw\"}]},\"scopes_supported\":[\"openid\",\"offline_access\"],\"logo_uri\":\"http://127.0.0.1:8000/static/svg/spid-logo-c-lb.svg\",\"organization_name\":\"SPID OIDC identity provider\",\"op_policy_uri\":\"http://127.0.0.1:8000/oidc/op/en/website/legal-information/\",\"request_parameter_supported\":true,\"request_uri_parameter_supported\":true,\"require_request_uri_registration\":true,\"response_types_supported\":[\"code\"],\"subject_types_supported\":[\"pairwise\",\"public\"],\"token_endpoint_auth_methods_supported\":[\"private_key_jwt\"],\"token_endpoint_auth_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"],\"userinfo_encryption_alg_values_supported\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"],\"userinfo_encryption_enc_values_supported\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"],\"userinfo_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"],\"request_object_encryption_alg_values_supported\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"],\"request_object_encryption_enc_values_supported\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"],\"request_object_signing_alg_values_supported\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]}},\"authority_hints\":[\"http://127.0.0.1:8000/\"]}";
        var metadataPolicy = "{\"contacts\":{\"essential\":true},\"subject_types_supported\":{\"value\":[\"pairwise\"]},\"id_token_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]},\"userinfo_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]},\"token_endpoint_auth_methods_supported\":{\"value\":[\"private_key_jwt\"]},\"userinfo_encryption_alg_values_supported\":{\"subset_of\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"]},\"userinfo_encryption_enc_values_supported\":{\"subset_of\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"]},\"request_object_encryption_alg_values_supported\":{\"subset_of\":[\"RSA-OAEP\",\"RSA-OAEP-256\",\"ECDH-ES\",\"ECDH-ES+A128KW\",\"ECDH-ES+A192KW\",\"ECDH-ES+A256KW\"]},\"request_object_encryption_enc_values_supported\":{\"subset_of\":[\"A128CBC-HS256\",\"A192CBC-HS384\",\"A256CBC-HS512\",\"A128GCM\",\"A192GCM\",\"A256GCM\"]},\"request_object_signing_alg_values_supported\":{\"subset_of\":[\"RS256\",\"RS384\",\"RS512\",\"ES256\",\"ES384\",\"ES512\"]}}";
        Assert.True(handler.ApplyMetadataPolicy(decodedOP, metadataPolicy) == default);
    }
}
