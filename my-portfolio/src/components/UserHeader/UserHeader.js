// JavaScript source code

import React from 'react';
import { useLocation } from 'react-router-dom';
import { ArrowRight16 } from '@carbon/icons-react';

import { header_primary, heading_sec__mb_bg, Image, ViewResumeLink } from './styles';

const UserHeader = ({ user }) => {
    const location = useLocation();

    return (
        <header_primary isHome={location.pathname === '/'}>
            <heading_sec__mb_bg>
                <Image src={user.basics.picture} />
                <div>
                    <h2>{user.basics.name}</h2>
                    <h4>
                        <a
                            href={`https://gitconnected.com/${user.basics.username}`}
                            target="_blank"
                            rel="noreferrer noopener"
                        >
                            @{user.basics.username}
                        </a>
                    </h4>
                    <p>{user.basics.label}</p>
                    <p>Coding in {user.basics.region}</p>
                    <p>{user.basics.yearsOfExperience} years of experience as a developer</p>
                    <p>{user.basics.headline}</p>
                    <p>
                        Blog:{' '}
                        <a href={user.basics.blog} target="_blank" rel="noreferrer noopener">
                            {user.basics.blog}
                        </a>
                    </p>
                </div>
            </heading_sec__mb_bg>
            <div>
                <ViewResumeLink
                    href={`https://gitconnected.com/${user.basics.username}/resume`}
                    target="_blank"
                    rel="noopener noreferrer"
                >
                    <span>View R�sum�</span>
                    <ArrowRight16 />
                </ViewResumeLink>
            </div>
        </header_primary>
    );
};

export default UserHeader;
