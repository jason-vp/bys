﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Text;
//using System.Data.SqlClient;
//using System.Data.SqlTypes;
using BySLib.EN;
using BySLib.LINQ;

namespace BySLib
{
    /// <summary>
    /// Esta clase representa la capa de acceso a datos del usuario
    /// </summary>
    public static class UsuarioCAD
    {
        /// <summary>
        /// Constante que indica los parámetros de conexión con la DB
        /// </summary>
        //private const string ConnectionString = "Data Source=Videoclub.sqlite;Version=3;New=False;Compress=True;";
        private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Videoclub.mdf;User Instance=true";


        #region CRUD'S

        public static void Create(BySBDDataContext p_ctx, Usuario p_cli)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_cli, 2, MemberInfoGetting.GetMemberName(() => p_cli));

            //#endregion

            p_ctx.Usuario.InsertOnSubmit(p_cli);
            p_ctx.SubmitChanges();


        }
        public static bool Update(BySBDDataContext p_ctx, Usuario p_cli)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_cli, 2, MemberInfoGetting.GetMemberName(() => p_cli));

            //#endregion

            Usuario update = (from t1 in p_ctx.Usuario
                              where t1.id == p_cli.id
                              select t1).First();

            update.nick = p_cli.nick;
            update.nombre = p_cli.nombre;
            update.mail = p_cli.mail;
            update.password = p_cli.password;
            update.telf = p_cli.telf;
            update.dir = p_cli.dir;
            update.credito = p_cli.credito;
            update.ruta_img = p_cli.ruta_img;
            update.puntuacion = p_cli.puntuacion;
            update.punt_total = p_cli.punt_total;
            update.num_votos = p_cli.num_votos;
            update.cod_postal = p_cli.cod_postal;
            update.nomb_pob = p_cli.nomb_pob;


            p_ctx.SubmitChanges();

            return true;
        }
        public static bool UpdateEnabled(BySBDDataContext p_ctx, int p_id, bool p_habilitado)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
            //    p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));
            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_habilitado, 3, MemberInfoGetting.GetMemberName(() => p_habilitado));

            //#endregion

            Usuario update = (from t1 in p_ctx.Usuario
                              where t1.id == p_id
                              select t1).First();

            update.habilitado = p_habilitado;

            p_ctx.SubmitChanges();

            return true;
        }

        /// <summary>
        /// Borra el usuario actual de la DB
        /// </summary>
        /// <returns>True si se borró</returns>
        public static bool Delete(BySBDDataContext p_ctx, int p_id)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
            //    p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

            //#endregion

            Usuario update = (from t1 in p_ctx.Usuario
                              where t1.id == p_id
                              select t1).First();

            update.eliminado = true;

            p_ctx.SubmitChanges();

            return true;
        }

        #endregion

        #region Getting Data

        public static Usuario GetById(BySBDDataContext p_ctx, int p_id)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
            //    p_id, 2, MemberInfoGetting.GetMemberName(() => p_id));

            //#endregion

            return (from t1 in p_ctx.Usuario
                    where t1.id == p_id
                    select t1).SingleOrDefault();

        }
        public static Usuario[] GetAll(BySBDDataContext p_ctx)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));

            //#endregion

            return (from t1 in p_ctx.Usuario
                    select t1).ToArray();
        }

        /// <summary>
        /// Obtiene todos los usuarios de la DB por id que no han sido eliminados
        /// </summary>
        /// <returns>Vector con los usuarios leidos de la DB</returns>
        public static Usuario[] GetAllNotDeletedByIdUsuario(BySBDDataContext p_ctx, int p_idUsuario)
        {
            //#region Check Parameters

            //ParameterChecker.CheckNullParameter(MethodBase.GetCurrentMethod(),
            //    p_ctx, 1, MemberInfoGetting.GetMemberName(() => p_ctx));
            //ParameterChecker.CheckEqualBiggerZero(MethodBase.GetCurrentMethod(),
            //    p_idUsuario, 2, MemberInfoGetting.GetMemberName(() => p_idUsuario));

            //#endregion

            return (from t1 in p_ctx.Usuario
                    where t1.id == p_idUsuario
                    && t1.eliminado == false
                    select t1).ToArray();
        }

        #endregion

        #region Public Methods
        public static bool ExistsByContainsEmail(BySBDDataContext p_ctx, string p_email)
        {

            return p_ctx.Usuario.Any(x => x.mail.Contains(p_email));
        }

        #endregion


    }
}
