// JavaScript source code

import styled from 'styled-components';

export const header_primary = styled.dev`.heading-primary {
    font - size: 6rem;
    text - transform: uppercase;
    letter - spacing: 3px;
    text - align: center;
}
@media only screen and(max - width: 37.5em) {
    .heading - primary {
        font - size: 4.5rem;
    }
}`;
export const heading_sec__mb_bg = styled.dev`.heading-sec__mb-bg {
    margin-bottom: 11rem;
}
@media only screen and(max - width: 56.25em) {
    .heading-sec__mb-bg {
        margin - bottom: 8rem;
    }
}`;

export const heading_sec__mb_med = styled.dev`.heading-sec__mb-med {
    margin - bottom: 9rem;
}
@media only screen and(max - width: 56.25em) {
    .heading-sec__mb-med {
        margin - bottom: 8rem;
    }
}`;

export const heading_sec__main=styled.dev`.heading-sec__main {
    display: block;
    font - size: 4rem;
    text - transform: uppercase;
    letter - spacing: 1px;
    letter - spacing: 3px;
    text - align: center;
    margin - bottom: 3.5rem;
    position: relative;
}
  .heading-sec__main--lt {
    color: #fff;
}
    .heading-sec__main--lt::after {
    content: '';
    background: #fff!important;
}
  .heading-sec__main::after {
    content: '';
    position: absolute;
    top: calc(100 % + 1.5rem);
    height: 5px;
    width: 3rem;
    background: #0062b9;
    left: 50 %;
    transform: translateX(-50 %);
    border - radius: 5px;
}
@media only screen and(max - width: 37.5em) {
      .heading-sec__main::after {
        top: calc(100 % + 1.2rem);
    }
}`;

export const heading_sec__sub = styled.dev`.heading-sec__sub {
    display: block;
    text - align: center;
    color: #777;
    font - size: 2rem;
    font - weight: 500;
    max - width: 80rem;
    margin: auto;
    line - height: 1.6;
}
@media only screen and(max - width: 37.5em) {
    .heading-sec__sub {
        font - size: 1.8rem;
    }
}`;
export const heading_sec__sub__lt = styled.dev`.heading-sec__sub--lt {
    color: #eee;
}`;


export const heading_sm  = styled.dev`.heading_sm {
    font - size: 2.2rem;
    text - transform: uppercase;
    letter - spacing: 1px;
}`;
